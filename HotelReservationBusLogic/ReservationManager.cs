using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationBusLogic
{
    public abstract class ReservationManagerBase
    {
        public abstract List<Reservation> GetReservations();
        public abstract void AddReservation(Reservation reservation);
        public class Reservation
        {
            public int ReservationId { get; set; }
            public string GuestName { get; set; }

        }
    }
}
