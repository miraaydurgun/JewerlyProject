using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.Controllers
{
    public class Shop_SingleController : Controller
    {
        Shop_SingleManager ssm = new Shop_SingleManager(new EfShop_SingleRepository());
        public IActionResult Index()
        //Jewelry'lerin listelendiği sayfa olacak
        {
            var values = ssm.TGetList();
            return View(values);

        }
    }
}
