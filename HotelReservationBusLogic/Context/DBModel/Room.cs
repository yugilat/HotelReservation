using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationBusLogic.Context.DBModel
{
    public class Room
    {
        public int RoomID { get; set; }
        public int HotelID { get; set; }
        public string RoomNumber {  get; set; }
        public string RoomType {  get; set; }
        public decimal RoomPrice { get; set; }
    }
}
