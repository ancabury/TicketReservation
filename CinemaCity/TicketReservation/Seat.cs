using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservation {
	public partial class Seat : UserControl {
		public int Position { get; set; }
		public int Number { get; set; }
		public double Price { get; set; }
		public string Category { get; set; }
		public int Availability { get; set; }
		
		public Seat() {
			InitializeComponent();
		}

		public override string ToString() {
			return "Position: "+Position.ToString() + "\nNumber: " + Number.ToString() + "\nPrice: " + Price.ToString();
		}

		public override bool Equals(object obj) {
			if (obj == null)
				return false;
			Seat crt = obj as Seat;
			if (crt == null)
				return false;
			if (crt.Position == this.Position && crt.Number == this.Number)
				return true;
			return false;
		}
	}
}
