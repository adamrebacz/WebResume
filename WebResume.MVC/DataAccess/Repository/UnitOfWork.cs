using System;
using WebResume.DataAccess.MVC.Repository.IRepository;

namespace WebResume.DataAccess.MVC.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WRDbContext _db;

        public ISectionRepository Section { get; private set; }

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
    }
}
