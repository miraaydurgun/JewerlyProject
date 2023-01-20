using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.ViewComponents.Shop_Single
{
    public class DescriptionListByShop_Single : ViewComponent
    {
        DescriptionManager dm = new DescriptionManager(new EfDescriptionRepository());
        public IViewComponentResult Invoke()
        {
            var values = dm.TGetList();
            return View(values);
        }
    }

}
