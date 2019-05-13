using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Classes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ExtraPrice { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
