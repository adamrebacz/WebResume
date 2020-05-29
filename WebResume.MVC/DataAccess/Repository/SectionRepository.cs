using System.Linq;
using WebResume.DataAccess.MVC.Repository.IRepository;
using WebResume.Models;

namespace WebResume.DataAccess.MVC.Repository
{
    public class SectionRepository : Repository<Section>, ISectionRepository
    {
        private readonly WRDbContext _db;

        public SectionRepository(WRDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

        public void Update(Section section)
        {
            var objFromDB = _db.Sections.SingleOrDefault(p => p.Id == section.Id);

            //objFromDB.Justification = permision.Justification;
            //...

            _db.SaveChanges();
        }
    }
}
