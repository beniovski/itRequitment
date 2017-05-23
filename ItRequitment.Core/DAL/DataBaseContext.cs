using ItRequitment.Core.Models;
using System.Data.Entity;

namespace ItRequitment.Core.DAL
{
    class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("databaseConection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> User { get; set; }
        public DbSet<JobOffer> JobOffer { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}