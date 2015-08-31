using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Model;
using System.Data.Entity;
using System.Windows.Forms;

namespace TicketReservation.Controller {
	public class Controller : IObservable<AvailableShow>, IObservable<Seat>{
		public List<Show> showsList { set; get; }
		public Show avShow { get; set; }
		private List<IObserver<AvailableShow>> obs;
		private List<IObserver<Seat>> obsSeats;
		private List<Client> clients;
		private Dictionary<Tuple<string, string>, List<Seat>> customers;
		private double changeOK, changeGOOD, changeEXCELLENT;
		public List<Seat> reserved { get; set; }

		public Controller() {
			var db = new ShowContext();
			showsList = db.Shows.ToList();
			obs = new List<IObserver<AvailableShow>>();
			obsSeats = new List<IObserver<Seat>>();
			clients = new List<Client>();
			avShow = new Show();
			customers = new Dictionary<Tuple<string, string>, List<Seat>>();
			reserved = new List<Seat>();
		}

		//admin related tasks
		public void add(string name, double price) {
			using (var db = new ShowContext()) {
				Show s = new Show { Name = name, Price = price };
				db.Shows.Add(s);
				showsList.Add(s);
				db.SaveChanges();
			}
		}

		public void delete(string name, double price) {
			using (var db = new ShowContext()) {
				Show s = new Show { Name = name, Price = price };
				var oldShow = from b in db.Shows
							  where b.Name == name
							  select b;
				if (avShow.ShowID != oldShow.First().ShowID) {
					db.Shows.Remove((Show)oldShow.First());
					db.SaveChanges();
					showsList = db.Shows.ToList();
				}
				else
					MessageBox.Show("Cannot delete the current available show.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void update(string oldName, string name, double price) {
			using (var db = new ShowContext()) {
				Show newShow = new Show { Name = name, Price = price };
				var oldShow = from b in db.Shows
							  where b.Name == oldName
							  select b;
				if (avShow.ShowID != oldShow.First().ShowID) {
					db.Shows.Remove((Show)oldShow.First());
					db.Shows.Add(newShow);
					db.SaveChanges();
					showsList = db.Shows.ToList();
				}
				else
					MessageBox.Show("Cannot update the current available show.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void makeShowAvailable(string name, string showRoom, DateTime time) {
			new AvailableShow(name, showRoom, time);
			avShow = showsList.Find(s => s.Name == AvailableShow.Instance.name);
			//update show title, room foreach client

			Notify();
		}

		public void registerClient(Client cl) {
			if (clients.Count >= 1) {
				cl.ctrl.changeOK = clients[0].ctrl.changeOK;
				cl.ctrl.changeGOOD = clients[0].ctrl.changeGOOD;
				cl.ctrl.changeEXCELLENT = clients[0].ctrl.changeEXCELLENT;
			}
			else {
				cl.ctrl.changeOK = avShow.Price;
				cl.ctrl.changeGOOD = avShow.Price * 2;
				cl.ctrl.changeEXCELLENT = avShow.Price * 2.5;
			}
			clients.Add(cl);
		}

		public void changePrice(string category, double price) {
			switch (category) {
				case "OK":
				changeOK = price;
				break;
				case "excellent":
				changeEXCELLENT = price;
				break;
				case "good":
				changeGOOD = price;
				break;
				default:
				break;
			}
			foreach (Client c in clients) {
				foreach (Control control in c.tableLayoutPanel7.Controls) {
					Seat s = control as Seat;
					switch (s.Category) {
						case "OK":
						s.Price = changeOK;
						break;
						case "excellent":
						s.Price = changeEXCELLENT;
						break;
						case "good":
						s.Price = changeGOOD;
						break;
						default:
						break;
					}
				}
			}
			NotifyChanges();
		}

		//Observer
		public IDisposable Subscribe(IObserver<AvailableShow> observer) {
			if (!obs.Contains(observer))
				obs.Add(observer);
			return new Unsubscriber(obs, observer);	
		}

		public IDisposable Subscribe(IObserver<Seat> observer) {
			if (!obsSeats.Contains(observer))
				obsSeats.Add(observer);
			return new Unsubscriber(obsSeats, observer);
		}

		public void Notify() {
			foreach (IObserver<AvailableShow> ob in obs)
				ob.OnCompleted();
		}

		public void NotifyChanges() {
			foreach (IObserver<AvailableShow> ob in obs)
				ob.OnNext(new AvailableShow());
		}

		public void NotifySeats() {
			foreach (IObserver<Seat> ob in obs)
				ob.OnNext(new Seat());
		}

		private class Unsubscriber : IDisposable {
			private List<IObserver<AvailableShow>> _observers;
			private IObserver<AvailableShow> _observer;

			private List<IObserver<Seat>> _observersSeat;
			private IObserver<Seat> _observerSeat;

			public Unsubscriber(List<IObserver<AvailableShow>> observers, IObserver<AvailableShow> observer) {
				this._observers = observers;
				this._observer = observer;
			}

			public void Dispose() {
				if (_observer != null && _observers.Contains(_observer))
					_observers.Remove(_observer);
			}

			public Unsubscriber(List<IObserver<Seat>> observers, IObserver<Seat> observer) {
				this._observersSeat = observers;
				this._observerSeat = observer;
			}

			public void DisposeSeat() {
				if (_observerSeat != null && _observersSeat.Contains(_observerSeat))
					_observersSeat.Remove(_observerSeat);
			}
		}

		//client related tasks
		public void setSeatPrice() {
			foreach (Client c in clients) {
				foreach (Control control in c.tableLayoutPanel7.Controls) {
					Seat s = control as Seat;
					//s.Price = avShow.Price;
					//s.Price = avShow.Price * 2;
					//s.Price = avShow.Price * 2.5;
					if (s.Category.CompareTo("OK") == 0)
						s.Price = changeOK;
					else if (s.Category.CompareTo("good") == 0)
						s.Price = changeGOOD;
					else
						s.Price = changeEXCELLENT;
				}
			}
		}

		public List<Seat> reserveSeats(List<Seat> seats, string name, string addr) {
			Tuple<string, string> newCust = new Tuple<string, string>(name, addr);
			if (!customers.ContainsKey(newCust)) {
				customers.Add(newCust, seats);
				return seats;
			}
			else {
				List<Seat> alreadyReserved = customers[newCust];
				foreach (Seat s in seats)
					alreadyReserved.Add(s);
				customers[newCust] = alreadyReserved;
				return alreadyReserved;
			}
		}

		public void confirmReservation(List<Seat> seats, string name, string addr) {
			Tuple<string, string> newCust = new Tuple<string, string>(name, addr);
			List<Seat> finalList = new List<Seat>();
			foreach (Seat s in seats) {
				finalList.Add(s);
				reserved.Add(s);
			}
			customers[newCust] = finalList;
			NotifySeats();
		}

	}
}
