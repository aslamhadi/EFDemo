using System;

namespace EFDemo.DAL.Structures
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
    }
}
