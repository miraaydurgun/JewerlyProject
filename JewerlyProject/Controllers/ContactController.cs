using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.Controllers
{
    public class ContactController : Controller
    {

        ContactManager cm = new ContactManager(new EfContactRepository());
        public IActionResult Index()
        //Jewelry'lerin listelendiği sayfa olacak
        {
            var values = cm.TGetList();
            return View(values);

        }
    
    }
}
