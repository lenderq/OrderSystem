using Microsoft.EntityFrameworkCore;
using OrderSystem.Models.Entities;

namespace OrderSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Clients> Clients { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
