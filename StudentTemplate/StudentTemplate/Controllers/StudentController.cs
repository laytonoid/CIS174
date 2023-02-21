using Microsoft.AspNetCore.Mvc;
using StudentTemplate.Models;
using System.Diagnostics;

namespace StudentTemplate.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Assignment()
        {
            return View();
        }
    }
}
