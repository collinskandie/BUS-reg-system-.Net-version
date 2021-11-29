using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bus_REG_system.Models;

namespace Bus_REG_system.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Bus_REG_system.Models.bus> bus { get; set; }
        public DbSet<Bus_REG_system.Models.Driver> Driver { get; set; }
        public DbSet<Bus_REG_system.Models.Route> Route { get; set; }
        public DbSet<Bus_REG_system.Models.Sacco> Sacco { get; set; }
    }
}