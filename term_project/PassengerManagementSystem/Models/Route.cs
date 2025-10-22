using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerManagementSystem.Models
{
    public class Route
    {
        public int RouteID { get; set; }  // Унікальний ID маршруту
        public string StartCity { get; set; } // Місто відправлення
        public string EndCity { get; set; }  // Місто прибуття

        // Зв'язок з рейсами
        public virtual ICollection<Tour> Tours { get; set; }
    }
}
