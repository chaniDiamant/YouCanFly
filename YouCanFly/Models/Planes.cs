using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Planes //יחיד
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public int NumberOfSeats { get; set; }

        public ICollection<Flight> Flights { get; set; }

        public ICollection<Seats> Seatses { get; set; }


    }
}
