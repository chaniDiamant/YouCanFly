using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Terminal
    {
        [Key]
        public string Name { get; set; }


        public ICollection<Flight> Flights { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

    }
}
