using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationBusLogic.Context.DBModel
{
    public class Hotel
    {
        public int HotelID {  get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactID { get; set; }
    }
}
