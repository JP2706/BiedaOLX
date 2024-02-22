using BiedaOLX.Core.Models.Domains;
using BiedaOLX.Core.Services;
using BiedaOLX.Core.ViewModels;
using BiedaOLX.Persistance.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Security.Cryptography.Xml;

namespace BiedaOLX.Controllers
{
    [Authorize]
    public class AnnouncementController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IAnnouncementService _announcementService;
        private readonly IImageService _imageService;
        private readonly IMyAppUserService _myAppUserService;

        public AnnouncementController(ICategoryService categoryService, IAnnouncementService announcementService, IImageService imageService, IMyAppUserService myAppUserService)
        {
            _categoryService = categoryService;
            _announcementService = announcementService;
            _imageService = imageService;
            _myAppUserService = myAppUserService;
        }

        public IActionResult Announcement(int id = 0)
        {
            var userId = User.GetUserId();
            var vm = GetAnnouncementViewModel(id, userId);


            return View(vm);
        }

        private AnnouncementViewModel GetAnnouncementViewModel(int id, string userId) 
        {
            return id == 0 ? new AnnouncementViewModel
            {
                Heading = "Dodaj ogłoszenie",
                Categories = _categoryService.Get(),
                NotOrUseds = _categoryService.NotOrUsedsGet(),
                Announcement = new Announcement { UserId = userId, CreatedDate = DateTime.Now },

            } : new AnnouncementViewModel
            {
                Heading = "Edytuj ogłoszenie",
                Categories = _categoryService.Get(),
                NotOrUseds = _categoryService.NotOrUsedsGet(),
                Announcement = _announcementService.GetOne(id, userId)
            };
        }

        [AllowAnonymous]
        public ActionResult AnnouncementReadOnly(int id) 
        {
            //var userId = User.GetUserId();
            var ann = _announcementService.GetOne(id);
            var vm = new AnnouncementReadOnlyViewModel
            {
                Announcement = ann,
                MyAppUserE = _myAppUserService.Get(ann.UserId)
            };
            return View(vm);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Announcement(Announcement announcement, IFormFile userFile = null)
        {
            var userId = User.GetUserId();
            announcement.UserId = userId;

            
            if (!ModelState.IsValid)
            {
                var vm = GetAnnouncementViewModel(announcement.Id, userId);
                return View(vm);
            }

            if (userFile != null)
                announcement.ImageFile = _imageService.UploadImage(userFile);
            else
                announcement.ImageFile = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/%3Fuestionmark.svg/800px-%3Fuestionmark.svg.png";


            if (announcement.Id == 0)
                _announcementService.Add(announcement);
            else
                _announcementService.Update(announcement);

            return RedirectToAction("Index","Home");
        }

    }
}


