﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Planes
    {
        public int Id { get; set; }

        public string PlanesName { get; set; }

        public string PlanesModel { get; set; }

        public int PlanesNumSeats { get; set; }



       

        public ICollection<Flight> Flights { get; set; }

        public ICollection<Seats> Seatses { get; set; }


    }
}
