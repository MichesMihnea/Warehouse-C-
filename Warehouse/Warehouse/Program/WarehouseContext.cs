using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using Warehouse.Model;

namespace Warehouse.Program
{
    public class WarehouseContext : System.Data.Entity.DbContext
    {
        public WarehouseContext() : base("WarehouseContext")
        {

        }

        public System.Data.Entity.DbSet<Product> Products { get; set; }

#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        protected void OnModelCreating(DbModelBuilder modelBuilder)
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
