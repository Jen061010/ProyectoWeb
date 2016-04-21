using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominios;

namespace Infraestructura
{
    public class CustomerDbContext : DbContext, ICustomerDbContext
    {
       
        public DbSet<ICustomer> Customers { get; set; }

 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    }
}
