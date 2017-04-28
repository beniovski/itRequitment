using ItRequitment.Models;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ItRequitments2.DAL
{
    class UserContext : DbContext
    {
        public UserContext() : base("databaseConection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> User{ get; set; }
    }
}