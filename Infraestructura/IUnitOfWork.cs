using System;
namespace Infraestructura
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
    }
}
