using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Orders
    {
        public int Id { get; set; }

        public int OrderNumber { get; set; }

        public string Terminal { get; set; }

        public DateTime OrderDate { get; set; }

        public Customers Customers { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
