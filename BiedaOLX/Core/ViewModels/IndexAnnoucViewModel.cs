using BiedaOLX.Core.Domains;
using BiedaOLX.Core.Models;
using BiedaOLX.Core.Models.Domains;
using System.Collections.Generic;

namespace BiedaOLX.Core.ViewModels
{
    public class IndexAnnoucViewModel
    {
        public IEnumerable<Announcement> Announcements { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<NotOrUsed> NotOrUseds { get; set; }
        public FilterAnnouncement FilterAnnouncement { get; set; }
        
    }
}
