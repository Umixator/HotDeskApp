using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDeskApp.Models
{
    public class HotDeskDbContext :DbContext
    {
        public HotDeskDbContext(DbContextOptions<HotDeskDbContext> options) : base(options)
        {
            
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Desk> Desks { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<UserDesk> UserDesks { get; set; }

    }
}
