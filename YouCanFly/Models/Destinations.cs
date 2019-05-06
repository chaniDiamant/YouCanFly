using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.TagHelpers.Internal;

namespace YouCanFly.Models
{
    public class Destinations
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public string Language { get; set; }
        public char CurrencyValue { get; set; }
        public string DestinationType { get; set; }

     

    }
}
