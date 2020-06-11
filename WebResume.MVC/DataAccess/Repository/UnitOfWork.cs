using System;
using System.Threading.Tasks;
using WebResume.MVC.DataAccess.Repository.IRepository;

namespace WebResume.MVC.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WRDbContext _db;

        public ISectionRepository Section { get; private set; }

        public IStringItemRepository StringItem { get; private set; }

        public IDateItemRepository DateItem { get; private set; }

        public ISectionDescriptionRepository SectionDescription { get; private set; }

        public UnitOfWork(WRDbContext dbContext)
        {
            _db = dbContext;
            Section = new SectionRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
