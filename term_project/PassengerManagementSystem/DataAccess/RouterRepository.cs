using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassengerManagementSystem.Models;

namespace PassengerManagementSystem.DataAccess
{
    public class RouterRepository
    {
        private readonly DatabaseContext _context;

        public RouterRepository(DatabaseContext context)
        {
            _context = context;
        }

        public RouterRepository()
        {
            _context = new DatabaseContext();
        }

        // Отримати всі маршрути
        public List<Route> GetAllRoutes()
        {
            return _context.Routes.ToList();
        }

        // Отримати маршрут за ID
        public Route GetRouteById(int id)
        {
            return _context.Routes.FirstOrDefault(r => r.RouteID == id);
        }

        // Додати новий маршрут
        public void AddRoute(Route route)
        {
            _context.Routes.Add(route);
            _context.SaveChanges();
        }

        // Оновити існуючий маршрут
        public void UpdateRoute(Route route)
        {
            _context.Entry(route).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Видалити маршрут
        public void DeleteRoute(int id)
        {
            var route = GetRouteById(id);
            if (route != null)
            {
                _context.Routes.Remove(route);
                _context.SaveChanges();
            }
        }
    }
}
