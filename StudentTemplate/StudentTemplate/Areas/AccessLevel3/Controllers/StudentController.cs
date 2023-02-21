using Microsoft.AspNetCore.Mvc;
using StudentTemplate.Models;
using System.Diagnostics;

namespace StudentTemplate.Areas.AccessLevel3.Controllers
{
    [Area("AccessLevel3")]
    public class StudentController : Controller
    {
        public IActionResult Assignment()
        {
            return View();
        }
    }
}
