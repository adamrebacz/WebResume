
using WebResume.Models;

namespace WebResume.DataAccess.MVC.Repository.IRepository
{
    public interface ISectionRepository : IRepository<Section>
    {
        void Update(Section section);
    }
}
