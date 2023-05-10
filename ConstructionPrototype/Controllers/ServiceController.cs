using ConstructionPrototype.Data;
using ConstructionPrototype.Data.Entities;
using ConstructionPrototype.Models;
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
        [HttpGet]
        public IActionResult CreateHomeArticle(HomeArticleCreateForm? CreateForm = null)
        {
            HomeArticleCreateViewModel viewModel = new HomeArticleCreateViewModel
            {
                CreateForm = CreateForm == null ? new HomeArticleCreateForm() : CreateForm,
                ActionPath = "CreateArticle"
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateArticle(HomeArticleCreateForm CreateForm)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("CreateHomeArticle");
            }


            HomeArticle article = new HomeArticle
            {
                Description = CreateForm.Description,
                ShortDescription = CreateForm.ShortDescription,
                Title = CreateForm.Title,
                Image = await IFormFileToBytes(CreateForm.Image)
            };

            _db.Add(article);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        private async Task<byte[]> IFormFileToBytes(IFormFile file)
        {
            if (file != null)
            {
                using var dataStream = new MemoryStream();
                await file.CopyToAsync(dataStream);
                return dataStream.ToArray();
            }
            else return null;
        }
    }
}
