using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.Controllers
{
    public class ContactController : Controller
    {

        ContactManager cm = new ContactManager(new EfContactRepository());
        public IActionResult Index()
        {
            var values = cm.TGetList();
            return View(values);

        }

    }
}
