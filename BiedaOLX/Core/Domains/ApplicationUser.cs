using BiedaOLX.Core.Domains;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BiedaOLX.Core.Models.Domains
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Announcements = new Collection<Announcement>();
        }

        //public override string NormalizedUserName { get; set; }

        public ICollection<Announcement> Announcements { get; set; }

        public MyAppUser MyAppUser { get; set; }

    }
}
