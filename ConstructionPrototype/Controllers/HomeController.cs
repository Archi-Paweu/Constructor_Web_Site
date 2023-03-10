using ConstructionPrototype.Data;
using ConstructionPrototype.Data.Entities;
using ConstructionPrototype.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConstructionPrototype.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbs;

        public HomeController(ApplicationDbContext dbs)
        {
            _dbs = dbs;
        }

        public IActionResult Index()
        {
            IEnumerable<HomeArticle> objList = _dbs.HomeArticles;
            return View(objList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
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