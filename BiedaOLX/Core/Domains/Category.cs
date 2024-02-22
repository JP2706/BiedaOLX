using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BiedaOLX.Core.Models.Domains
{
    public class Category
    {
        public Category()
        {
            Announcements = new Collection<Announcement>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Announcement> Announcements { get; set; }
    }
}
