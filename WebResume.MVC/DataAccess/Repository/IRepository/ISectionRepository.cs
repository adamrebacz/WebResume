
using WebResume.Models;

namespace WebResume.MVC.DataAccess.Repository.IRepository
{
    public interface ISectionRepository : IRepository<Section>
    {
        void Update(Section section);
    }
}
