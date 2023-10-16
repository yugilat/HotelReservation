// See https://aka.ms/new-console-template for more information

using HotelReservationModel.Model;

namespace IHotelReservation
{
    public interface IHotel
    {

        public void Account(Login userDetails);

        public void Login(Login userDetails);
    }
}
