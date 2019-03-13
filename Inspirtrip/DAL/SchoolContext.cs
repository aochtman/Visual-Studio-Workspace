using Inspirtrip.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Inspirtrip.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
        }

        public DbSet<User> Users { get; set; }
        //public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Itinerary> Itineraries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}