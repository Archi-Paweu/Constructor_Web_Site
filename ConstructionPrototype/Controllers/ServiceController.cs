using Microsoft.AspNetCore.Mvc;

namespace ConstructionPrototype.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult JoinUs()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        //[Route("/Service/LogIn/Create/JoinUsArticle")]
        //[Route("/")]
        public IActionResult CreateJoinUs()
        {
            return View();
        }
    }
}
