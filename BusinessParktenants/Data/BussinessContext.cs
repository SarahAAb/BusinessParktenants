using BusinessParktenants.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace BusinessParktenants.Data
{
    public class BussinessContext:IdentityDbContext<ApplicationUsers>
    {
        IConfiguration configuration;

        public BussinessContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Complain> Complains { get; set; }
        public DbSet<Suggestion> Suggestions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("BusinessPark"));

            base.OnConfiguring(optionsBuilder);
        }
    }
}
