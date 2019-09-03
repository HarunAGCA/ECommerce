using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Agca.ECommerce.DataAccess.Concrete.EntityFramework.Contexts
{
    public class ECommerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.; Database=ECommerce; Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        
    }
}
