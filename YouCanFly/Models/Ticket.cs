using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Ticket
    {
        [Key]
        public int TicketNumber { get; set; }

        public DateTime LandingDate { get; set; }
        public DateTime TakeOffTime { get; set; }

        public Terminal Terminal { get; set; }
        public Flight Flight { get; set; }

        public Customers Customer { get; set; }

        public ICollection<Seats> Seatses { get; set; }

      
        public Department Department { get; set; }//לשנות לשם הנכון של המחלקה
    

        public Orders Order { get; set; }

    }
}
