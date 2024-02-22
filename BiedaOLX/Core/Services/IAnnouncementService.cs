using BiedaOLX.Core.Models;
using BiedaOLX.Core.Models.Domains;
using System.Collections;
using System.Collections.Generic;

namespace BiedaOLX.Core.Services
{
    public interface IAnnouncementService
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
