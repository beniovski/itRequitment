using ItRequitment.Models;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ItRequitment.DAL
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