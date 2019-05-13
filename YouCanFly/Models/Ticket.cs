using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int TicketNumber { get; set; }

        //one to many
        public Flight Flight { get; set; }

        public Customers Customers { get; set; }

        public Seats Seats { get; set; }

        public Destinations Destinations { get; set; }

        public Classes Classes { get; set; }

        public Orders Orders { get; set; }

    }
}
