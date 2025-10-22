using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassengerManagementSystem.Models;

namespace PassengerManagementSystem.DataAccess
{
    public class PassengersRepository
    {
        private readonly DatabaseContext _context;

        public PassengersRepository(DatabaseContext context)
        {
            _context = context;
        }

        public PassengersRepository()
        {
            _context = new DatabaseContext();
        }

        // Отримання всіх пасажирів
        public List<Passenger> GetAllPassengers()
        {
            return _context.Passengers.ToList();
        }

        // Отримання пасажира за ID
        public Passenger GetPassengerById(int id)
        {
            return _context.Passengers.FirstOrDefault(p => p.PassengerID == id);
        }

        // Додавання нового пасажира
        public void AddPassenger(Passenger passenger)
        {
            _context.Passengers.Add(passenger);
            _context.SaveChanges();
        }

        // Оновлення даних пасажира
        public void UpdatePassenger(Passenger passenger)
        {
            _context.Entry(passenger).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Видалення пасажира
        public void DeletePassenger(int id)
        {
            var passenger = GetPassengerById(id);
            if (passenger != null)
            {
                _context.Passengers.Remove(passenger);
                _context.SaveChanges();
            }
        }

    }
}
