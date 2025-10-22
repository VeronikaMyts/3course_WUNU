using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassengerManagementSystem.Models;

namespace PassengerManagementSystem.DataAccess
{
    public class TicketsRepository
    {
        private readonly DatabaseContext _context;

        public TicketsRepository(DatabaseContext context)
        {
            _context = context;
        }

        public TicketsRepository()
        {
            _context = new DatabaseContext();
        }

        // Отримання всіх квитків
        public List<Ticket> GetAllTickets()
        {
            return _context.Tickets.ToList();
        }

        // Отримання квитка за ID
        public Ticket GetTicketById(int id)
        {
            return _context.Tickets.FirstOrDefault(t => t.TicketID == id);
        }

        // Додавання нового квитка
        public void AddTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        // Оновлення даних квитка
        public void UpdateTicket(Ticket ticket)
        {
            _context.Entry(ticket).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Видалення квитка
        public void DeleteTicket(int id)
        {
            var ticket = GetTicketById(id);
            if (ticket != null)
            {
                _context.Tickets.Remove(ticket);
                _context.SaveChanges();
                
            }
        }
    }
}
