using Microsoft.AspNetCore.Mvc;

namespace MovieList.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
