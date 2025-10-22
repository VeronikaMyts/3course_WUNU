using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerManagementSystem.Models
{
    public class Passenger
    {
        public int PassengerID { get; set; }   // Унікальний ID пасажира
        public string FirstName { get; set; }  // Ім'я пасажира
        public string LastName { get; set; }   // Прізвище пасажира
        public string PassportNumber { get; set; }  // Номер паспорту пасажира
        public string Email { get; set; }      // Email пасажира
        public string ContactNumber { get; set; } // Номер телефону

        // Зв'язок з квитками
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
