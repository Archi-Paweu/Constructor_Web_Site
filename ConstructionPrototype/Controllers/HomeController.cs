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

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<HomeArticle> objList = _dbs.HomeArticles;
            return View(objList);
        }

        public IActionResult ArticleDetails(string id)
        {
            var article = _dbs.HomeArticles.Where(article => article.Id.Equals(id)).FirstOrDefault();


            if (article == null)
            {

                return NotFound();
            }


            return View(article);
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

        public string byteArrayToImage(byte[] bytesArr)
        {
            var base64 = Convert.ToBase64String(bytesArr);
            var imgSrc = String.Format("data:image/gif;base64,{0}", base64);
            return imgSrc;
        }
    }
}