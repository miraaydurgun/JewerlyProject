using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.Controllers
{
    public class ShopController : Controller
    {
        ShopManager sm = new ShopManager(new EfShopRepository());
        public IActionResult Index()
        //Jewelry'lerin listelendiği sayfa olacak
        {
            var values = sm.TGetList();
            return View(values);

        }
    }
}
