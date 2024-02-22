using System.Collections.Generic;
using BiedaOLX.Core.Models;
using BiedaOLX.Core.Models.Domains;

namespace BiedaOLX.Core.Repositories
{
    public interface IAnnouncementRepository
    {
        IEnumerable<Announcement> Get(FilteringIndexAnn filter);
        IEnumerable<Announcement> GetUserAnn(string userId);
        Announcement GetOne(int id);

        Announcement GetOne(int id, string userId);

		void Add(Announcement announcement);
        void Update(Announcement announcement);
        void Delete(int id);

    }
}
