using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using TicketReservation.Controller;
using TicketReservation.Model;

namespace TicketReservation {
	public partial class Admin : Form {
		public Controller.Controller ctrl { get; set; }
		public Admin(Controller.Controller ctrl) {
			this.ctrl = ctrl;
			InitializeComponent();
			InitializeShows();
		}

		private void InitializeShows(){
			while (listBoxShows.Items.Count > 0)
				listBoxShows.Items.RemoveAt(0);
			List<Show> ls = ctrl.showsList;
			foreach (Show s in ls)
				listBoxShows.Items.Add(s.Name);
		}

		private void listBoxShows_SelectedIndexChanged(object sender, EventArgs e) {
			if (listBoxShows.SelectedIndex >= 0) {
				List<Show> ls = ctrl.showsList;
				foreach (Show s in ls)
					if (s.Name == listBoxShows.SelectedItem.ToString()) {
						textBoxName.Text = s.Name;
						textBoxPrice.Text = s.Price.ToString();
					}
			}
		}

		private void buttonClear_Click(object sender, EventArgs e) {
			textBoxName.Clear();
			textBoxPrice.Clear();
		}

		private void buttonAdd_Click(object sender, EventArgs e) {
			if (textBoxName.Text != string.Empty && textBoxPrice.Text != string.Empty) {
				ctrl.add(textBoxName.Text, Convert.ToDouble(textBoxPrice.Text));
				InitializeShows();
				buttonClear_Click(sender, e);
			}
			else
				MessageBox.Show("Fill in the information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void buttonDelete_Click(object sender, EventArgs e) {
			if (listBoxShows.SelectedIndex < 0)
				MessageBox.Show("Select a show to be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else {
				ctrl.delete(textBoxName.Text, Convert.ToDouble(textBoxPrice.Text));
				InitializeShows();
				buttonClear_Click(sender, e);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e) {
			if (listBoxShows.SelectedIndex >= 0) {
				ctrl.update(listBoxShows.SelectedItem.ToString(), textBoxName.Text, Convert.ToDouble(textBoxPrice.Text));
				InitializeShows();
				buttonClear_Click(sender, e);
			}
			else
				MessageBox.Show("Select a show to be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void buttonMakeAv_Click(object sender, EventArgs e) {
			if (listBoxShows.SelectedIndex < 0)
				MessageBox.Show("Please select a show.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (textBoxShowRoom.Text == string.Empty)
				MessageBox.Show("Please insert a room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				ctrl.makeShowAvailable(listBoxShows.SelectedItem.ToString(), textBoxShowRoom.Text, dateTimePicker.Value);
		}

		private void buttonChgPrice_Click(object sender, EventArgs e) {
			if (comboBoxSeatCateg.SelectedIndex < 0)
				MessageBox.Show("Select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else {
				if (textBoxChgPrice.Text == string.Empty)
					ctrl.changePrice(comboBoxSeatCateg.SelectedItem.ToString(), 0);
				else
					ctrl.changePrice(comboBoxSeatCateg.SelectedItem.ToString(), Convert.ToDouble(textBoxChgPrice.Text));
			}
		}
	}
}
