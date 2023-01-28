using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShopAController : Controller
    {
        ShopManager shopManager = new ShopManager(new EfShopRepository());
        public IActionResult Index()
        {
            //ViewBag.v1 = "Deneyim Paneli";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            //ViewBag.v2 = "Deneyimler";
            //ViewBag.v3 = "Deneyim Paneli";

            var values = shopManager.TGetList();
            return View(values);
        }

        //Ekleme
        [HttpGet]
        public IActionResult AddShop()
        {
            ViewBag.v1 = "Deneyim Ekleme";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";

            return View();
        }
        [HttpPost]
        public IActionResult AddShop(Shop shop)
        {
            ViewBag.v1 = "Deneyim Ekleme";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";

            ExperienceValidator validations = new ExperienceValidator();
            ValidationResult results = validations.Validate(shop);

            if (results.IsValid) //eğer giriş için olumsuz şart yoksa ekler
            {

                shopManager.TAdd(shop);
                return RedirectToAction("Index");//Ekledikten sonra tekrar listelemesini istediğimiz için yaptık
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);//Burada hata ismi ve mesajını alıp add sayfasına gönderdik
                }
            }
            return View();

        }

        //Silme
        public IActionResult DeleteShop(int id)
        {
            var values = shopManager.TGetByID(id);
            shopManager.TDelete(values);
            return RedirectToAction("Index");
        }


        //Güncelleme
        [HttpGet]
        public IActionResult EditShop(int id)
        {
            ViewBag.v1 = "Deneyim Güncelleme";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Güncelleme";
            var values = shopManager.TGetByID(id);
            shopManager.TUpdate(values);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditShop(Shop shop)
        {
            ViewBag.v1 = "Deneyim Güncelleme";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Güncelleme";
            ExperienceValidator validations = new ExperienceValidator();
            ValidationResult results = validations.Validate(shop);

            if (results.IsValid) //eğer giriş için olumsuz şart yoksa ekler
            {

                shopManager.TUpdate(shop);
                return RedirectToAction("Index");//Ekledikten sonra tekrar listelemesini istediğimiz için yaptık
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);//Burada hata ismi ve mesajını alıp add sayfasına gönderdik
                }
            }
            return View();

        }


    }
}
