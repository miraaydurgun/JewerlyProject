using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.ViewComponents.Shop_Single
{
    public class ReviewListByShop_Single : ViewComponent
    {
        ReviewManager rm = new ReviewManager(new EfReviewRepository());
        public IViewComponentResult Invoke()
        {
            var values = rm.TGetList();
            return View(values);
        }
    }
   
    
}
