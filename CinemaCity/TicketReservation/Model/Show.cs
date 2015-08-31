using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TicketReservation.Model {
	public class Show {
		public int ShowID { get; set; }

		[Required, StringLength(100), Display(Name = "Name")]
		public string Name { get; set; }
		[Required, Display(Name = "Price")]
		public double Price { get; set; }
	}
}
