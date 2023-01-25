using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Multi_PageWebAppLayton.Models;

namespace Multi_PageWebAppLayton.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }
        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }
            public IActionResult Index()
            {
            List<Contact> contacts = context.Contacts.OrderBy(m => m.Name)
                .ToList();
            return View(contacts);
            }
        }
}