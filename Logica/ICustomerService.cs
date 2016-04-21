using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


using Infraestructura;
using Dominios;
namespace Logica
{
    public interface ICustomerService
    {
        //public ICustomerDbContext Context { get; set; }


        ICustomer Add(ICustomer c);
        int Delete(ICustomer c);
        ICustomer Get(int id);
        int Update();

    }
}
