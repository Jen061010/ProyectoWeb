using Dominios;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CustomerService : ICustomerService
    {
        readonly ICustomerDbContext _context;

        public CustomerService(ICustomerDbContext ctx)
        {
            if (null == ctx)
            {
                throw new ArgumentNullException("CustomerContext");
            }
            _context = ctx;
        }

        public Customer Add(Customer c)
        {
            _context.Customers.Add(c);
            SaveChanges();
            return c;
        }

        public int Delete(ICustomer c)
        {
            _context.Customers.Remove(c);
            return SaveChanges();
        }

        public ICustomer Get(int id)
        {
            return _context.Customers.Where(c => c.Id == id).FirstOrDefault();
        }

        public int Update()
        {
            return SaveChanges();
        }

        private int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
