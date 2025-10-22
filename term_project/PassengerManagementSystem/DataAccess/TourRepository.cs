using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassengerManagementSystem.Models;

namespace PassengerManagementSystem.DataAccess
{
    public class ToursRepository
    {
        private readonly DatabaseContext _context;

        public ToursRepository(DatabaseContext context)
        {
            _context = context;
        }

        public ToursRepository()
        {
            _context = new DatabaseContext();
        }

        // Отримання всіх турів
        public List<Tour> GetAllTours()
        {
            return _context.Tours
                   .Include(t => t.Route)  // Завантажуємо маршрут
                   .Include(t => t.Carriers)
                   .Include(t => t.Tickets)// Завантажуємо перевізників
                   .ToList();
            
        }

        // Отримання туру за ID
        public Tour GetTourById(int id)
        {
            return _context.Tours.FirstOrDefault(t => t.TourID == id);
        }

        // Додавання нового туру
        public void AddTour(Tour tour)
        {
            _context.Tours.Add(tour);
            _context.SaveChanges();
        }

        // Оновлення даних туру
        public void UpdateTour(Tour tour)
        {
            _context.Entry(tour).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Видалення туру
        public void DeleteTour(int id)
        {
            var tour = GetTourById(id);
            if (tour != null)
            {
                _context.Tours.Remove(tour);
                _context.SaveChanges();
            }
        }
    }
}
