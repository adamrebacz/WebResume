using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebResume.Models;
using WebResume.MVC.DataAccess.Repository.IRepository;

namespace WebResume.MVC.DataAccess.Repository
{
    public class SectionDescriptionRepository : Repository<SectionDescription>, ISectionDescriptionRepository
    {
        private readonly WRDbContext _db;
        public SectionDescriptionRepository(WRDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

        public void Update(SectionDescription sectionDescription)
        {
            throw new NotImplementedException();
        }
    }
}
