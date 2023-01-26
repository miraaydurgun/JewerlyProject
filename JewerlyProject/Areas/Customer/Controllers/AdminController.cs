using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.Controllers
{
    public class AdminController : Controller
    {
        [Area("Customer")]

        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult NavigationPartial()
        {
            return PartialView();
        }
    }
}
