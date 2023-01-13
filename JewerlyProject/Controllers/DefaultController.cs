using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.Controllers
{
    [Authorize]
    public class DefaultController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        //Partial View kullanarak sayfanın belirlenen alannını farklı bir sayfa gibi kullanarak bölüp, parçalayıp, yönetebiliriz.
        public PartialViewResult PartialHead()

        {
            return PartialView();
        }
        public PartialViewResult PartialSlideBar()

        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()

        {
            return PartialView();
        }

    }

}
