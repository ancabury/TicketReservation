using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservation.Model {
	public class AvailableShow {
		private static AvailableShow instance;
		public string name { get; set; }
		public string room { get; set; }
		public DateTime time { get; set; }
		public static AvailableShow Instance {
			get {
				if (instance == null)
					instance = new AvailableShow();
				return instance;
			}
		}
		public AvailableShow() {
			this.name = "No show selected yet.";
			this.room = "No room selected yet.";
		}
		public AvailableShow(string name, string room, DateTime time) {
			if (instance == null) {
				instance = new AvailableShow();
				instance.name = name;
				instance.room = room;
				instance.time = time;
			}
			else {
				instance.name = name;
				instance.room = room;
				instance.time = time;
			}
		}
	}
}
