using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZigWheels.Models;

namespace ZigWheels.Data
{
    public class ZigWheelsContext : DbContext
    {
        public ZigWheelsContext (DbContextOptions<ZigWheelsContext> options)
            : base(options)
        {
        }

        public DbSet<ZigWheels.Models.Car> Car { get; set; }

        public DbSet<ZigWheels.Models.CarShop> CarShop { get; set; }

        public DbSet<ZigWheels.Models.User> User { get; set; }

        public DbSet<ZigWheels.Models.Role> Role { get; set; }
    }
}
