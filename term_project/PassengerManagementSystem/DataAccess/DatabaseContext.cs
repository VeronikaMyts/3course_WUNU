using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassengerManagementSystem.Models;

namespace PassengerManagementSystem.DataAccess
{
    public class DatabaseContext : DbContext
    {
        // Конструктор, що підключається до бази даних за допомогою connection string з app.config
        public DatabaseContext() : base("name=PassengerManagementSystem")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        // DbSet для роботи з пасажирами
        public virtual DbSet<Passenger> Passengers { get; set; }

        // DbSet для роботи з рейсами
        public virtual DbSet<Tour> Tours { get; set; }

        // DbSet для роботи з квитками
        public virtual DbSet<Ticket> Tickets { get; set; }

        // DbSet для роботи з перевізниками
        public virtual DbSet<Carrier> Carriers { get; set; }

        // DbSet для роботи з маршрутами
        public virtual DbSet<Route> Routes { get; set; }

        // DbSet для роботи з користувачами (якщо потрібен доступ до реєстрацій)
        public virtual DbSet<User> Users { get; set; }

        // Для звітів 
        
    }
}
