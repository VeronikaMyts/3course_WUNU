using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassengerManagementSystem.Models;
using System.Data.Entity;
using PassengerManagementSystem.DataAccess;

namespace PassengerManagementSystem.DataAccess
{
    public class CarrierRepository
    {
        private readonly DatabaseContext _context;

        public CarrierRepository(DatabaseContext context)
        {
            _context = context;
        }

        public CarrierRepository()
        {
            _context = new DatabaseContext();
        }

        // Отримати всіх перевізників
        public List<Carrier> GetAllCarriers()
        {
            return _context.Carriers.ToList();
        }

        // Отримати перевізника за ID
        public Carrier GetCarrierById(int id)
        {
            return _context.Carriers.FirstOrDefault(c => c.CarrierID == id);
        }

        // Додати нового перевізника
        public void AddCarrier(Carrier carrier)
        {
            _context.Carriers.Add(carrier);
            _context.SaveChanges();
        }

        // Оновити існуючого перевізника
        public void UpdateCarrier(Carrier carrier)
        {
            _context.Entry(carrier).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Видалити перевізника
        public void DeleteCarrier(int id)
        {
            var carrier = GetCarrierById(id);
            if (carrier != null)
            {
                _context.Carriers.Remove(carrier);
                _context.SaveChanges();
            }
        }
    }
}
