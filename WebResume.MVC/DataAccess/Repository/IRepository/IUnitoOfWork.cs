using System;
namespace WebResume.DataAccess.MVC.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ISectionRepository Section { get; }

        void Save();
    }
}
