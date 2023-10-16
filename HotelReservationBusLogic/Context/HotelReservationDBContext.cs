using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelReservationBusLogic.Context.DBModel;

namespace HotelReservationBusLogic.Context
{
    public class HotelReservationDBContext:DbContext
    {

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<ReservationRoom> ReservationRooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Kyoten;Database=HotelReservationDB;Trusted_Connection=True;TrustServerCertificate=True; Encrypt=false;");
        }
    }
}
