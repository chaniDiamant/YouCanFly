using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Customers
    {
        public int Id { get; set; }

        public int CustomerPassport { get; set; }

        public string CustomerName { get; set; }

        public string CustomerCountry { get; set; }

        public string CustomerAddress { get; set; }

        public int CustomerPhone { get; set; }

        public DateTime CustomerDateOfBirth { get; set; }

        public ICollection<Orders> Orderses { get; set; }


    }
}
