using System.Linq;
using WebResume.MVC.DataAccess.Repository.IRepository;
using WebResume.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebResume.MVC.DataAccess.Repository
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
            throw new System.NotImplementedException();
        }

        public async Task UpdateAsync(Section section)
        {
            var objFromDB = await _db.Sections.SingleOrDefaultAsync(p => p.Id == section.Id);

            objFromDB.Name = section.Name;
            objFromDB.Visible = section.Visible;

            await _db.SaveChangesAsync();
        }

    }
}
