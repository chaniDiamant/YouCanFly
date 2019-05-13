using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Flight
    {
        public int Id { get; set; }

        public int FlightNumber { get; set; }

        public string TakeOffTime { get; set; }

        public  string LandingTime { get; set; }

        public DateTime TakeOffDate { get; set; }

        public DateTime LandingDate { get; set; }

        public double PriceFlight { get; set; }
    }
}
