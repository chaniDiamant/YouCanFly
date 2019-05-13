﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Seats
    {
        public int SeatsId { get; set; }

        public string SeatsType { get; set; }

        public string SeatsColor { get; set; }
        //one to many
        public Planes Planes { get; set; }

        public Ticket Ticket { get; set; }


    }
}
