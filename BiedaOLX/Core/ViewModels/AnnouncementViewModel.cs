using BiedaOLX.Core.Domains;
using BiedaOLX.Core.Models.Domains;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace BiedaOLX.Core.ViewModels
{
    public class AnnouncementViewModel
    {
        public string Heading { get; set; }
        public Announcement Announcement { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<NotOrUsed> NotOrUseds { get; set; }

    }
}
