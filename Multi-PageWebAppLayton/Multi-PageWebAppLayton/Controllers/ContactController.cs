using Microsoft.AspNetCore.Mvc;
using Multi_PageWebAppLayton.Models;

namespace Multi_PageWebAppLayton.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }
        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add"; 
            return View("Add", new Contact());
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
                context.Contacts.Add(contact);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }
        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contacts.Remove(contact); 
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}