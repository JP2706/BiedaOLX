using BiedaOLX.Core;
using BiedaOLX.Core.Domains;
using BiedaOLX.Core.Models.Domains;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BiedaOLX.Persistance
{
    public class ApplicationDbContext : IdentityDbContext, IApplicationDBContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NotOrUsed> NotOrUseds { get; set; }
        public DbSet<MyAppUser> MyAppUsers { get; set; }
    }
}
