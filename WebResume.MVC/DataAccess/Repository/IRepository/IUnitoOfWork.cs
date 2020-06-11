using System;
using System.Threading.Tasks;

namespace WebResume.MVC.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ISectionRepository Section { get; }
        IStringItemRepository StringItem { get; }
        IDateItemRepository DateItem { get; }
        ISectionDescriptionRepository SectionDescription { get; }

        void Save();

        Task SaveAsync();
    }
}
