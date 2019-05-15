using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Flight
    {
        [Key]
        public int FlightNumber { get; set; }

        public DateTime TakeOff { get; set; }

        public DateTime Landing { get; set; }

        public float Price { get; set; }

        public Terminal Terminal { get; set; } 
        public Destinations Destination { get; set; }

        public Planes Plane { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
