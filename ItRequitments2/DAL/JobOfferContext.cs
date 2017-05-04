using ItRequitment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ItRequitments.DAL
{
    public class JobOfferContext : DbContext
    {
        public DbSet<JobOffer> JobOffer { get; set; }

        public JobOfferContext() : base("databaseConection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
       
    }
}