using BakeryShop.Data.Configurations;
using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryShop.Data
{
    // we will work using fluent api not data annotaions 
    public class BakeryShopContext : DbContext
    {
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configure DBcontext to use sqllite
            optionsBuilder.UseSqlite(@"Datasource=BakeryDB.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // apply configuration exists in ProductConfiguration --> Migrate
            modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
        }


    }
}
