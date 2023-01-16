using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.ViewComponents.Home
{
    public class NewArrivalListByHome:ViewComponent
    {

        NewArrivalManager hm = new NewArrivalManager(new EfNewArrivalRepository());
        public IViewComponentResult Invoke()
        {
            var values = hm.TGetList();
            return View(values);
        }
    }
}
