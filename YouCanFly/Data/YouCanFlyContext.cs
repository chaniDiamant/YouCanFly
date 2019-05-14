using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YouCanFly.Models;

namespace YouCanFly.Models
{
    public class YouCanFlyContext : DbContext
    {
        public YouCanFlyContext (DbContextOptions<YouCanFlyContext> options)
            : base(options)
        {
        }

        public DbSet<YouCanFly.Models.Classes> Classes { get; set; }

        public DbSet<YouCanFly.Models.Customers> Customers { get; set; }

        public DbSet<YouCanFly.Models.Destinations> Destinations { get; set; }

        public DbSet<YouCanFly.Models.Flight> Flight { get; set; }

        public DbSet<YouCanFly.Models.Orders> Orders { get; set; }

        public DbSet<YouCanFly.Models.Planes> Planes { get; set; }

        public DbSet<YouCanFly.Models.PlaneUnit> PlaneUnit { get; set; }

        public DbSet<YouCanFly.Models.Seats> Seats { get; set; }

        public DbSet<YouCanFly.Models.Terminal> Terminal { get; set; }

        public DbSet<YouCanFly.Models.Ticket> Ticket { get; set; }
    }
}
