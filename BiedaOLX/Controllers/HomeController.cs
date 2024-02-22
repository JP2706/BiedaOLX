using BiedaOLX.Core.Models;
using BiedaOLX.Core.Services;
using BiedaOLX.Core.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BiedaOLX.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAnnouncementService _annService;
        private readonly ICategoryService _categoryService;

        public HomeController(ILogger<HomeController> logger, IAnnouncementService annService, ICategoryService categoryService)
        {
            _logger = logger;
            _annService = annService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            //var userId = User.GetUserId();

            var vm = new IndexAnnoucViewModel
            {
                Announcements = _annService.Get(GetFilterParams(null, 0,0)),
                FilterAnnouncement = new FilterAnnouncement(),
                Categories = _categoryService.Get(),
                NotOrUseds = _categoryService.NotOrUsedsGet(),
            };

            return View(vm);
        }

        private FilteringIndexAnn GetFilterParams(string title, int catId, int noUsId)
        {
            return new FilteringIndexAnn
            {
                Title = title,
                CategoryId = catId,
                NotOrUsedId = noUsId
			};
        }

        [HttpPost]
        public IActionResult Index(IndexAnnoucViewModel viewModel)
        {
            //var userId = User.GetUserId();
            var anns = _annService.Get(GetFilterParams(viewModel.FilterAnnouncement.Title, viewModel.FilterAnnouncement.CategoryId, viewModel.FilterAnnouncement.NotOrUsedId));

            return PartialView("_IndexAnnsView", anns);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
