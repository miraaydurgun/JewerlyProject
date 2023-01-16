using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.ViewComponents.Home
{
    public class ReviewListByHome:ViewComponent
    {
        ReviewManager hm = new ReviewManager(new EfReviewRepository());
        public IViewComponentResult Invoke()
        {
            var values = hm.TGetList();
            return View(values);
        }
    }
}
