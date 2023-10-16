using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationBusLogic
{
    public class ConcreteReservationManager : ReservationManagerBase
    {
        private List<Reservation> reservations;

        public ConcreteReservationManager()
        {
            reservations = new List<Reservation>
            {
                new Reservation { ReservationId = 1, GuestName = "Elden John" },
                new Reservation { ReservationId = 2, GuestName = "Jane Hunter" },
            };
        }
        public override List<Reservation> GetReservations()
        {
            return reservations;
        }

        public override void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }
    }
}
