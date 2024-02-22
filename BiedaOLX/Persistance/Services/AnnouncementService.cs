using BiedaOLX.Core;
using BiedaOLX.Core.Models;
using BiedaOLX.Core.Models.Domains;
using BiedaOLX.Core.Services;
using System.Collections.Generic;

namespace BiedaOLX.Persistance.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AnnouncementService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Announcement> Get(FilteringIndexAnn filter)
        {
            return _unitOfWork.Announcement.Get(filter);
        }

        public Announcement GetOne(int id)
        {
            return _unitOfWork.Announcement.GetOne(id);
        }


        public IEnumerable<Announcement> GetUserAnn(string userId)
		{
			return _unitOfWork.Announcement.GetUserAnn(userId);
		}

		public Announcement GetOne(int id, string userId)
        {
            return _unitOfWork.Announcement.GetOne(id, userId);
        }

        public void Add(Announcement announcement) 
        {
            _unitOfWork.Announcement.Add(announcement);
            _unitOfWork.Complete();
        }

        public void Update(Announcement announcement)
        {
            _unitOfWork.Announcement.Update(announcement);
            _unitOfWork.Complete();
        }

		public void Delete(int id)
        {
            _unitOfWork.Announcement.Delete(id);
            _unitOfWork.Complete();
        }
	}
}
