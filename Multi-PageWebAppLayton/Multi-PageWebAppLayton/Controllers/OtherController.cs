using Microsoft.AspNetCore.Mvc;

namespace Multi_PageWebAppLayton.Controllers
{
    [Route("Custom/[controller]/[action]")]
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            return Content("Other Controller!");
        }
    }
}
