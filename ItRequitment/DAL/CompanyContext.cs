using ItRequitment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ItRequitments.DAL
{
    public class CompanyContext : DbContext
    {
        public DbSet<Company> Company { get; set; } 

        public CompanyContext() : base ("databaseConection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}