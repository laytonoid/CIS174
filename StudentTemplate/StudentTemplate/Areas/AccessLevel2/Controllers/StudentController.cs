using Microsoft.AspNetCore.Mvc;
using StudentTemplate.Models;
using System.Diagnostics;

namespace StudentTemplate.Areas.AccessLevel2.Controllers
{
    [Area("AccessLevel2")]
    public class StudentController : Controller
    {
        public IActionResult Assignment()
        {
            return View();
        }
    }
}
