using System;
namespace WebResume.MVC.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ISectionRepository Section { get; }

        void Save();
    }
}
