using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.ViewComponents.CheckOut
{
    public class ShopListByCheckOut : ViewComponent
    {
        ShopManager sm = new ShopManager(new EfShopRepository());
        public IViewComponentResult Invoke()
        {
            var values = sm.TGetList();
            return View(values);
        }
    }
}
