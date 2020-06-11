using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebResume.Models;
using WebResume.MVC.DataAccess.Repository.IRepository;

namespace WebResume.MVC.DataAccess.Repository
{
    public class DateItemRepository : Repository<DateItem>, IDateItemRepository
    {
        private readonly WRDbContext _db;
        public DateItemRepository(WRDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

        public void Update(DateItem dateItem)
        {
            throw new NotImplementedException();
        }
    }
}
