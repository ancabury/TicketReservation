using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TicketReservation.Model {
	class ShowsInitializer : DropCreateDatabaseIfModelChanges<ShowContext> {
		protected override void Seed(ShowContext context) {
			GetShows().ForEach(s => context.Shows.Add(s));
		}

		private static List<Show> GetShows(){
			var shows = new List<Show> {
                new Show
                {
					ShowID = 1,
                    Name = "LA RĂSCRUCE DE VÂNTURI",
					Price = 5.6
                },
                new Show
                {
					ShowID = 2,
                    Name = "HAMLET",
					Price = 7
                },
                new Show
                {
					ShowID = 3,
                    Name = "ULTIMA NOAPTE DE RAZBOI, INTAIA NOAPTE DE DRAGOSTE",
					Price = 6
                },
                new Show
                {
					ShowID = 4,
                    Name = "CONUL LEONIDA FAŢĂ CU REACŢIUNEA",
					Price = 4
                },
                new Show
                {
					ShowID = 5,
                    Name = "INSULA",
					Price = 3.99
                },
            };

			return shows;
		}
	}
}
