using pvpt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace pvpt.DAL
{
    public class BdContext : DbContext
    {
        public BdContext() : base("BdContext") //constructor de context
        { }

        public DbSet<User> Users { get; set; } //set de entitati

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}