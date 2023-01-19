using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.ViewComponents.Home
{
    public class NewArrivalListByHome:ViewComponent
    {

        NewArrivalManager nam = new NewArrivalManager(new EfNewArrivalRepository());
        public IViewComponentResult Invoke()
        {
            var values = nam.TGetList();
            return View(values);
        }
    }
}
