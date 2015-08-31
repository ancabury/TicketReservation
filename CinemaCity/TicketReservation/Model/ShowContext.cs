using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TicketReservation.Model {
	public class ShowContext : DbContext{
		public DbSet<Show> Shows { get; set; }

		public ShowContext()
			: base("TicketReseravion") {
				Database.SetInitializer(new ShowsInitializer());
		}
	}
}
