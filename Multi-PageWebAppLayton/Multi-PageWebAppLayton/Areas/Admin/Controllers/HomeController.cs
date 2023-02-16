using Microsoft.AspNetCore.Mvc;

namespace Multi_PageWebAppLayton.Areas.Admin.Controllers
{
    [Area("Admin")]
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

