// See https://aka.ms/new-console-template for more information


using HotelReservationBusLogic;
using IHotelReservation;
using HotelReservationModel.Model;


Login Current_Account = new Login();

Current_Account.FirstName = "adsfadfs";
Current_Account.LastName = "asdugvf";
IHotel iface = new InventoryManager();
iface.Login(Current_Account);
iface.Account(Current_Account);

