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

namespace TicketReservation {
	public partial class LogIn : Form {
		private Controller.Controller ct;
		Admin ad;
		public LogIn() {
			InitializeComponent();
			ct = new Controller.Controller();
		}

		private void buttonAdmin_Click(object sender, EventArgs e) {
			LayoutUsrPass.Visible = true;
			buttonLogAdmin.Visible = true;
			buttonClient.Visible = false;
			buttonAdmin.Visible = false;
		}

		private void buttonLogAdmin_Click(object sender, EventArgs e) {
			if (textBoxUser.Text == "admin" && textBoxPasswd.Text == "admin") {
				ad = new Admin(ct);
				ad.Show();
				buttonClient.Visible = true;
				LayoutUsrPass.Visible = false;
				buttonLogAdmin.Visible = false;
				buttonAdmin.Enabled = false;
			}
			else {
				MessageBox.Show("Incorrect credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				LayoutUsrPass.Visible = false;
				buttonLogAdmin.Visible = false;
				buttonClient.Visible = true;
				buttonAdmin.Visible = true;
				textBoxPasswd.Clear();
				textBoxUser.Clear();
			}
		}

		private void buttonClient_Click(object sender, EventArgs e) {
			if (ad != null && ad.ctrl.avShow.Name != null) {
				Client cl = new Client(ct);

				(cl as Client).Subscribe(ct);
				(cl as Client).SubscribeSeat(ct);
				cl.Show();
			}
			else
				MessageBox.Show("There is no show available.\nPlease come back later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
