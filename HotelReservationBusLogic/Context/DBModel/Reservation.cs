using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelReservationBusLogic.Context.DBModel
{
    public class Reservation
    {
        public int ReservationID {  get; set; }
        public int CustomerID { get; set; }
        public int RoomID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set;}
        public decimal TotalAmount {  get; set; }
        public string ReservationStatus {  get; set; }
        public string ReservationName {  get; set; }
        public Customer Customer { get; set; }
        public Room Room { get; set; }
    }
}
