using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.TagHelpers.Internal;

namespace YouCanFly.Models
{
    public class Destinations //יחיד
    {
        public int DestinationId { get; set; }

        public string Name { get; set; }

        

        public string Language { get; set; }

        public char CurrencyValue { get; set; }

  

        public ICollection<Flight> Flights { get; set; }

      

    }
}
