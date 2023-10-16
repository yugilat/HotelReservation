using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationBusLogic.Context.DBModel
{
    public class ReservationRoom
    {
        public int ReservationID { get; set; }
        public int RoomID {  get; set; }
        public int Quantity {  get; set; }
    }
}
