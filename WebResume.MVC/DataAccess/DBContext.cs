using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebResume.Models;

namespace WebResume.MVC.DataAccess
{
    public class WRDbContext : IdentityDbContext
    {
        public DbSet<Section> Sections { get; set; }
        public DbSet<SectionDescription> SectionDescriptions { get; set; }
        public DbSet<DateItem> DateItems { get; set; }
        public DbSet<StringItem> StringItems { get; set; }

        public WRDbContext(DbContextOptions<WRDbContext> options)
            : base(options)
        {

        }
    }
}
