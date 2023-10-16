using Microsoft.AspNetCore.Mvc;
using HotelReservationBusLogic;

public class ReservationsController : Controller
{
    private readonly ReservationManager _reservationManager;

    public ReservationsController(ReservationManagerBase reservationManager)
    {
        _reservationManager = reservationManager;
    }

    public IActionResult Index()
    {
        var reservations = _reservationManager.GetReservations();

        return View();
    }
}

