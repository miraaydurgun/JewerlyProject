using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JewelryProject.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Route("Customer/[Controller]/[Action]")] //Attribute Routing yapıyoruz, Area kullandığımız içi çalıştığımız sayfaların başına Customer ekledik.

    public class LoginController : Controller
    {
        private readonly SignInManager<CustomerUser> _signInManager;
        //login controllwesN CTRL.ile generate costructure yoluyla dependency injection yaptık
        //ve sign in manager clasını field clasına atadık.
        public LoginController(SignInManager<CustomerUser> signInManager)
        {
            _signInManager = signInManager;
        }

        //Signinmanager identity paketi ile beraber gelen login classıdır.
        //Entity değeri olarak customeruserdan gelen propertyleri veriyoruz
        //bunuda _signinmanager fieldine atıyoruz

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
                //SignInManager klasında oluşturmuş olduğumuz asenkron metot kullanıcı adı,
                //password, kullanıcı hatırlama durumu (çerez) ve lockout(hatalı giriş sayısı) kontrolü ister.

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Jewelry");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
                }
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
