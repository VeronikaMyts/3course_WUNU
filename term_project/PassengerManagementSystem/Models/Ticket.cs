using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerManagementSystem.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }   // Унікальний ID квитка
        public int PassengerID { get; set; }  // ID пасажира
        public int TourID { get; set; }      // ID рейсу
        public decimal Price { get; set; }    // Ціна квитка
        public bool IsBooked { get; set; }    // Статус бронювання

        // Зв'язок з пасажирами
        public virtual Passenger Passenger { get; set; }
        // Зв'язок з рейсами
        public virtual Tour Tour { get; set; }
    }
}
