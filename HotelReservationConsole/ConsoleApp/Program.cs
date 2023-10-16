using System;
using HotelReservationBusLogic.Context;
using HotelReservationBusLogic.Context.DBModel;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hotel Reservation System");
            Console.WriteLine("------------------------");

            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            var reservation = new Reservation
            {
                Customer = new Customer
                {
                    FirstName = firstName,
                },
                Room = new Room
                {

                },
            };

            SaveReservation(reservation);

            Console.WriteLine("Reservation successfully saved!");
        }

        private static void SaveReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}