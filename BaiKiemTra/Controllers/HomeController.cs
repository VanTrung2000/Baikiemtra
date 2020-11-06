using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BaiKiemTra.Models;
using BaiKiemTra.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BaiKiemTra.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppContetxt _appDbContext;
        public HomeController(ILogger<HomeController> logger, AppContetxt appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Posts> posts = _appDbContext.Posts ;

            return View(posts);
        }

        public IActionResult Create()
        {
            HomeIndex homeIndex = new HomeIndex()
            {
                Posts = new Posts(),
                CategoriesSelectList = _appDbContext.Categories.Select(item => new SelectListItem
                {
                    Text = item.Title,
                    Value = item.ToString()
                }),
                TagsSelectList = _appDbContext.Categories.Select(item => new SelectListItem
                {
                    Text = item.Title,
                    Value = item.ToString()
                }),

            };
            return View(homeIndex);
        }
        [HttpPost]
        public IActionResult Create(HomeIndex homeIndex)
        {
            _appDbContext.Posts.Add(homeIndex.Posts);
            _appDbContext.SaveChanges();

            return View(homeIndex);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

