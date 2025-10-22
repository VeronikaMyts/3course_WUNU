using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PassengerManagementSystem.Models
{
    public class Carrier
    {
        public int CarrierID { get; set; }   // Унікальний ID перевізника
        public string Name { get; set; }      // Назва компанії перевізника
        public string ContactNumber { get; set; }  // Номер телефону перевізника
        public string Email { get; set; }     // Email перевізника

        // Зв'язок з рейсами
        public virtual ICollection<Tour> Tours { get; set; }
    }
}
