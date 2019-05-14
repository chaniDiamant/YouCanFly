using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Seats //יחיד
    {
        public int Id { get; set; }

        public string Color { get; set; }
        //one to many
        public Planes Planes { get; set; }

        public Ticket Ticket { get; set; }


    }
}
