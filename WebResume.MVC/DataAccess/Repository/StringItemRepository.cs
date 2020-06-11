using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebResume.Models;
using WebResume.MVC.DataAccess.Repository.IRepository;

namespace WebResume.MVC.DataAccess.Repository
{
    public class StringItemRepository : Repository<StringItem>, IStringItemRepository
    {
        private readonly WRDbContext _db;
        public StringItemRepository(WRDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

        public void Update(StringItem stringItem)
        {
            throw new NotImplementedException();
        }
    }
}
