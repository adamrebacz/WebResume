using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebResume.Models;

namespace WebResume.DataAccess.MVC
{
    public class WRDbContext : IdentityDbContext
    {
        public DbSet<Section> Sections { get; set; }

        public WRDbContext(DbContextOptions<WRDbContext> options)
            : base(options)
        {

        }
    }
}
