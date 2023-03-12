using ConstructionPrototype.Data;
using ConstructionPrototype.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionPrototype.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ServiceController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult JoinUs()
        {
            IEnumerable<JobOffer> objList = _db.JobOffers;
            return View(objList);
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }




        // Creation of Join Us article
        public IActionResult CreateJoinUs()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(JobOffer obj)
        {
            _db.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("LogIn");
        }




        // Creation of Home Page article
        public IActionResult CreateHomeArticle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateArticle(HomeArticle obj)
        {
            _db.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
