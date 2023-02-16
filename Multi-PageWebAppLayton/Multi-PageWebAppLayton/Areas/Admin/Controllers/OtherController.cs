using Microsoft.AspNetCore.Mvc;

namespace Multi_PageWebAppLayton.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Custom/[controller]/[action]")]
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            return Content("Other Controller!");
        }
    }
}
