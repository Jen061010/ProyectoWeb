using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;
using System.Data.Entity;

namespace Infraestructura
{
    public interface ICustomerDbContext : IUnitOfWork
    {
        public IDbSet<ICustomer> Customers{ get; set; }
    }
}
