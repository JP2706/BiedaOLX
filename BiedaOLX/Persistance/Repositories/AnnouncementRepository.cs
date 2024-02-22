using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BiedaOLX.Core;
using BiedaOLX.Core.Models;
using BiedaOLX.Core.Models.Domains;
using BiedaOLX.Core.Repositories;
using Microsoft.AspNetCore.Identity;

namespace BiedaOLX.Persistance.Repositories
{
    public class AnnouncementRepository : IAnnouncementRepository
    {
        private readonly IApplicationDBContext _context;

        public AnnouncementRepository(IApplicationDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Announcement> Get(FilteringIndexAnn filter)
        {
            var anno = _context.Announcements.Include(x => x.Category).Where(x => x.Id != 0);

            if (filter.CategoryId != 0)
                anno = anno.Where(x => x.CategoryId == filter.CategoryId);

            if (!string.IsNullOrWhiteSpace(filter.Title))
                anno = anno.Where(x => x.Title.Contains(filter.Title));

			if (filter.NotOrUsedId != 0)
				anno = anno.Where(x => x.NotOrUsedId == filter.NotOrUsedId);

			return anno.OrderBy(x => x.CreatedDate);
        }

		public IEnumerable<Announcement> GetUserAnn(string userId)
        {
            return _context.Announcements.Where(x => x.UserId == userId);
        }


		public Announcement GetOne(int id, string userId)
        {
            return _context.Announcements.
                Include(x => x.Category).
                Include(x => x.NotOrUsed).
                Single(x => x.Id == id && x.UserId == userId);
        }

        public Announcement GetOne(int id)
        {
            return _context.Announcements.
                Include(x => x.Category).
                Include(x => x.NotOrUsed).
                Include(x => x.User).
                Single(x => x.Id == id);
        }

        public void Add(Announcement announcement) 
        {
            _context.Announcements.Add(announcement);
        }

        public void Update(Announcement announcement)
        {
            var announcementToUpdate = _context.Announcements.Single(x => x.Id == announcement.Id);
            announcementToUpdate.Title = announcement.Title;
            announcementToUpdate.Body = announcement.Body;
            announcementToUpdate.CategoryId = announcement.CategoryId;
            announcementToUpdate.Street = announcement.Street;
            announcementToUpdate.StreetNumer = announcement.StreetNumer;
            announcementToUpdate.PostCode = announcement.PostCode;
            announcementToUpdate.City = announcement.City;
            announcementToUpdate.Value = announcement.Value;
            announcementToUpdate.ImageFile = announcement.ImageFile;
        }

		public void Delete(int id)
        {
            var annToDelete = _context.Announcements.Single(x => x.Id == id);
            _context.Announcements.Remove(annToDelete);
        }

	}
}
