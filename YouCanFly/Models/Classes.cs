using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YouCanFly.Models
{
    public class Classes //לשנות שם ליחיד +לשנות שם של המודל ל///unit
    {
         [Key]

        public string Name { get; set; }

        public double ExtraPrice { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
         
    }
}
