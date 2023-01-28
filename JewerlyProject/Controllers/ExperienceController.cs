using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.Controllers
{
    public class ShopController : Controller
    {
        ShopManager shopmanager = new ShopManager(new EfShopRepository());
        public IActionResult Index()
        {
            ViewBag.v1 = "Ürün Paneli";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            ViewBag.v2 = "Ürünler";
            ViewBag.v3 = "Ürün Paneli";

            var values = shopmanager.TGetList();
            return View(values);
        }

        //Ekleme
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Ürün Ekleme";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            ViewBag.v2 = "Ürünler";
            ViewBag.v3 = "Ürün Ekleme";
            
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Shop shop)
        {
            ViewBag.v1 = "Ürün Ekleme";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            ViewBag.v2 = "Ürünler";
            ViewBag.v3 = "Ürün Ekleme";

            ExperienceValidator validations =new ExperienceValidator();  
            ValidationResult results=validations.Validate(shop);

            if (results.IsValid) //eğer giriş için olumsuz şart yoksa ekler
            {

                shopmanager.TAdd(shop);
                return RedirectToAction("Index");//Ekledikten sonra tekrar listelemesini istediğimiz için yaptık
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);//Burada hata ismi ve mesajını alıp add sayfasına gönderdik
                }
            }
            return View();

        }

        //Silme
        public IActionResult DeleteExperience(int id)
        {
            var values = shopmanager.TGetByID(id);
            shopmanager.TDelete(values);
            return RedirectToAction("Index");
        }


        //Güncelleme
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Ürün Güncelleme";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            ViewBag.v2 = "Ürünler";
            ViewBag.v3 = "Ürün Güncelleme";
            var values = shopmanager.TGetByID(id);
            shopmanager.TUpdate(values);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditExperience(Shop shop)
        {
            ViewBag.v1 = "Ürün Güncelleme";//ViewBag ile gönderdiğimiz değer sayfaya aktarılır istenilen yerde kullanılır. AddSkill sayfasına.
            ViewBag.v2 = "Ürünler";
            ViewBag.v3 = "Ürün Güncelleme";
            ExperienceValidator validations = new ExperienceValidator();
            ValidationResult results = validations.Validate(shop);

            if (results.IsValid) //eğer giriş için olumsuz şart yoksa ekler
            {

                shopmanager.TUpdate(shop);
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
