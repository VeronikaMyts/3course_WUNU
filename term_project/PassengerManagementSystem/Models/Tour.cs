using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PassengerManagementSystem.Models
{
    public class Tour
    {
        public int TourID { get; set; }   // Унікальний ID рейсу
        public DateTime DepartureDate { get; set; }  // Дата відправлення
        public DateTime ArrivalDate { get; set; }    // Дата прибуття
        public int RouteID { get; set; }  // ID маршруту
        public virtual Route Route { get; set; }   // Навігаційна властивість для маршруту

        // Зв'язок з водіями
        public virtual ICollection<Carrier> Carriers { get; set; }
        // Зв'язок з квитками
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
