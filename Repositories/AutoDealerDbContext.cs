using AutoDealer.Models;
using AutoDealer.Models.Customer;
using AutoDealer.Models.Purchase;
using AutoDealer.Models.Special;
using AutoDealer.Models.VehicleComponents;
using Microsoft.EntityFrameworkCore;

namespace AutoDealer.Repositories
{
    public class AutoDealerDbContext : DbContext
    {
        public AutoDealerDbContext(DbContextOptions<AutoDealerDbContext> options) : base(options)
        {
        }

        public DbSet<CustomerRecord> CustomerRecords { get; set; }
        public DbSet<PurchaseRecord> PurchaseRecords { get; set; }
        public DbSet<Special> Specials { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ExteriorColor> ExteriorColors { get; set; }
        public DbSet<InteriorColor> InteriorColors { get; set; }
        public DbSet<ModelType> Models { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<ContactRequest> ContactRequests { get; set; }
    }
}
