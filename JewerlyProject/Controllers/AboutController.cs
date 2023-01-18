using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.Controllers
{
    public class AboutController : Controller
    {

        AboutManager abm = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        //Jewelry'lerin listelendiği sayfa olacak
        {
            var values = abm.TGetList();
            return View(values);

        }
    }
}
