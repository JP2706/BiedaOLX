using BiedaOLX.Core.Models.Domains;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BiedaOLX.Core.Domains
{
    public class NotOrUsed
    {
        public NotOrUsed()
        {
            Announcement = new Collection<Announcement>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Announcement> Announcement { get; set; }
    }
}
