using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Customers //customer
    {
        [Key]
        [DisplayName("מספר דרכון")]
        public int Passport { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public DateTime DateOfBirth { get; set; }

        public ICollection<Orders> Orderses { get; set; }


    }
}
