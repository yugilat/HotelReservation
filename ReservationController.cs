using HotelReservationBusLogic; 
using Microsoft.AspNetCore.Mvc;

namespace HotelWeb.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IHotelReservationManager _reservationManager;

        public ReservationController(IHotelReservationManager reservationManager)
        {
            _reservationManager = reservationManager;
        }

        public IActionResult Index()
        {
            var reservations = _reservationManager.GetReservations();

            return View();
        }
    }
}
