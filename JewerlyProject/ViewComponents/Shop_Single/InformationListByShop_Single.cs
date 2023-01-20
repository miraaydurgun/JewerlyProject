using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.ViewComponents.Shop_Single
{
    public class InformationListByShop_Single : ViewComponent
    {
        InformationManager ifm = new InformationManager(new EfInformationRepository());
        public IViewComponentResult Invoke()
        {
            var values = ifm.TGetList();
            return View(values);
        }
    
    }
}
