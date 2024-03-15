using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class GenreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
