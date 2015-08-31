using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketReservation.Controller;
using TicketReservation.Model;

namespace TicketReservation {
	public partial class Client : Form, IObserver<AvailableShow>, IObserver<Seat> {
		public Controller.Controller ctrl { get; set; }
		private IDisposable unsubs;
		private IDisposable unsubsSeat;
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
		List<Seat> selectedSeats;
		public Client(Controller.Controller ctrl) {
			this.ctrl = ctrl;
			selectedSeats = new List<Seat>();
			InitializeComponent();
			InitializeShowInfo();
			makeChanges();
			updateSeats();
		}

		private void InitializeShowInfo() {
			ctrl.registerClient(this);
			labelRoomName.Text = AvailableShow.Instance.room;
			labelShowName.Text = AvailableShow.Instance.name;
			labelTime.Text = AvailableShow.Instance.time.ToShortTimeString();
			InitializePrice();
			setToolTip();
		}

		private void makeChanges() {
			setToolTip();
		}

		private void setToolTip() {
			foreach (Control control in tableLayoutPanel7.Controls) {
				Seat s = control as Seat;
				toolTipSeat.SetToolTip(s, s.ToString());
			}
		}

		private void InitializePrice() {
			ctrl.setSeatPrice();
		}

		public void Subscribe(IObservable<AvailableShow> provider) {
			if (provider != null)
				unsubs = provider.Subscribe(this);
		}

		public void SubscribeSeat(IObservable<Seat> provider) {
			if (provider != null)
				unsubsSeat = provider.Subscribe(this);
		}

		public void Unsubscribe() {
			unsubs.Dispose();
		}

		public void OnCompleted() {
			InitializeShowInfo();
		}

		public void OnError(Exception error) {
			throw new NotImplementedException();
		}

		public void OnNext(AvailableShow av) {
			makeChanges();
		}

		public void OnNext(Seat value) {
			updateSeats();
		}

		private void seat1_Click(object sender, EventArgs e) {
			Seat s = (Seat)sender;
			if (s.Availability == 0) {
				//make selected, add to current selected list
				s.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seatSel.BackgroundImage")));
				s.Availability = 2;
				selectedSeats.Add(s);
			}
			else if (s.Availability == 1) {
				//do nothing, it is reserved
				s.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seatR.BackgroundImage")));
				s.Availability = 1;
			}
			else {
				//deselect, make available
				s.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seatAv.BackgroundImage")));
				s.Availability = 0;
				selectedSeats.Remove(s);
			}
		}

		private void buttonReserve_Click(object sender, EventArgs e) {
			if (textBoxAddress.Text == string.Empty || textBoxName.Text == string.Empty)
				MessageBox.Show("Please insert your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else {
				List<Seat> reserved = ctrl.reserveSeats(selectedSeats, textBoxName.Text, textBoxAddress.Text);
				double price = 0;
				foreach (Seat s in reserved) {
					if (s.Availability == 1) {
						s.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seatSel.BackgroundImage")));
						s.Availability = 0;
						selectedSeats.Add(s);
					}
					price += s.Price;
				}
				MessageBox.Show("Please confirm selection.\nTotal price: " + price.ToString(), "Informmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
				textBoxAddress.Enabled = false;
				textBoxName.Enabled = false;
				buttonReserve.Enabled = false;
			}
			showMySeats();
		}

		private void buttonConfirm_Click(object sender, EventArgs e) {
			ctrl.confirmReservation(selectedSeats, textBoxName.Text, textBoxAddress.Text);
			updateSeats();
		}

		private void showMySeats() {
			foreach (Seat s in selectedSeats) {
				foreach (Control c in tableLayoutPanel7.Controls) {
					Seat crtS = c as Seat;
					if (s.Equals(c)) {
						crtS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seatSel.BackgroundImage")));
						crtS.Availability = 2;
					}
				}
			}
		}

		private void updateSeats() {
			foreach (Seat s in ctrl.reserved) {
				//do nothing, it is reserved
				foreach (Control c in tableLayoutPanel7.Controls) {
					Seat crtS = c as Seat;
					if (s.Equals(c)) {
						crtS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seatR.BackgroundImage")));
						crtS.Availability = 1;
					}
				}
			}
		}

	}
}
