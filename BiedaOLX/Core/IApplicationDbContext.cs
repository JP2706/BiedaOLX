using BiedaOLX.Core.Domains;
using BiedaOLX.Core.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace BiedaOLX.Core
{
    public interface IApplicationDBContext
    {
        DbSet<Announcement> Announcements { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<NotOrUsed> NotOrUseds { get; set; }
        DbSet<MyAppUser> MyAppUsers { get; set; }
        int SaveChanges();


    }
}
