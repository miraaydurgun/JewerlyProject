
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.Controllers
{

    public class JewelryController : Controller
    {
        HomeManager hm = new HomeManager(new EfHomeRepository());
        public IActionResult Index()
        //Jewelry'lerin listelendiği sayfa olacak
        {
            var values = hm.GetHomeWithCampaign();
            return View(values);
          
        }
    }
}
