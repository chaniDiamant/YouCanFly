using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Orders
    {
        public int OrderId { get; set; }

        public DateTime Date { get; set; }

        public Customers Customer { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
