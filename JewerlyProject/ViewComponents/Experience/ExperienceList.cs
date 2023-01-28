using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ShopManager shopManager = new ShopManager(new EfShopRepository());

        public IViewComponentResult Invoke() //Invoke view componente gitmeyi sağlayan metottur. Shared içinde Default.cshtml açılır
        {
            var values = shopManager.TGetList();
            return View(values);
        }
    }
}

