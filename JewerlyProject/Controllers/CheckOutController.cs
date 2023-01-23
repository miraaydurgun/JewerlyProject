using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.Controllers
{
    public class CheckOutController : Controller
    {
        CheckOutManager com = new CheckOutManager(new EfCheckOutRepository());
        public IActionResult Index()
        {
            var values = com.TGetList();
            return View(values);
        }
    }
}
