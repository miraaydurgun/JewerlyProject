using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace JewelryProject.Controllers
{
    public class ReviewController : Controller
    {
        ReviewManager rm = new ReviewManager(new EfReviewRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Review r)
        {
            r.ReviewDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            r.ReviewStatus = true;
            rm.TAdd(r);
            return RedirectToAction("Index");
        }
    }
}
