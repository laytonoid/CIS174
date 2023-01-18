using Microsoft.AspNetCore.Mvc;
using Responsive.Models;
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.Name = "Taylor";
        ViewBag.BirthYear = 2000;
        ViewBag.FV = 0;
        return View();
    }
    [HttpPost]
    public IActionResult Index(ResponsiveModel model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.FV = model.CalculateAge();
        }
        else
        {
            ViewBag.FV = 0;
        }
        return View(model);
    }
}