using BiedaOLX.Core.Models.Domains;
using BiedaOLX.Core.Services;
using BiedaOLX.Persistance.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

namespace BiedaOLX.Areas.Identity.Pages.Account.Manage
{
    public class MyAnnouncementsModel : PageModel
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IImageService _imageService;

		public MyAnnouncementsModel(IAnnouncementService announcementService, IImageService imageService)
        {
            _announcementService = announcementService;
            _imageService = imageService;
		}
        public  IEnumerable<Announcement> Announcements {  get; set; }

        public void OnGet()
        {
            var userId = User.GetUserId();
			Announcements = _announcementService.GetUserAnn(userId);
		}

        public void OnPostDeleteMyAnn(int id)
        {
            var annImageFilePath = _announcementService.GetOne(id).ImageFile;
            _announcementService.Delete(id);
            if (annImageFilePath != "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/%3Fuestionmark.svg/800px-%3Fuestionmark.svg.png")
            {
                annImageFilePath = annImageFilePath.Remove(0, 1);
                _imageService.DeletImage(annImageFilePath);
            }
            OnGet();
			
        }
            
	}
}
