using Core_Proje.Areas.Customer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Route("Customer/[Controller]/[Action]")] //Attribute Routing yapıyoruz, Area kullandığımız içi çalıştığımız sayfaların başına Customer ekledik.
    public class RegisterController : Controller
    { //UserMAnager Classı identity paketi ile beraber gelmiş bir class
        private readonly UserManager<CustomerUser> _userManager; //customer userı çağırıyoruz ve buradan gelen dataları _usermanager üzerinden kullanacağız
        //Oluşturmuş olduğumuz CustomerUser classını UserMAnager ile generik yaptık ve _usermanager fieldıa aşağıda CRUD işlemleri için kullanılmak üzere atadık

        public RegisterController(UserManager<CustomerUser> userManager) //kayıtların kontrolü yapılacak
        {
            _userManager = userManager;
            //UserManager üzerinden dependency injection yaparak CRUD işlemlerini gerçekleştireceğiz
        }


        //Kapsülleme gibi düşün 
       

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {

            //AspNetUsers tamamlandığına buraya dönecek

            if (ModelState.IsValid) // eğer Bütün şartları sağlıyorsa
            {



                CustomerUser w = new CustomerUser() //değerleri al
                //CustomerUser bizim AspNetUsers tablosundaki alanları taşıyan metodumuz,
                //buraya biz 3 alan daha eklemiştik aşağıda formdan gelen değerler
                //bu metod içideki alanlara atanır.
                {
                    Name = p.Name,
                    Surname = p.SurName,
                    Email = p.Mail,
                    UserName = p.UserName,
                    ImageURL = p.ImageUrl,
                    //forma yazdığımız değerler sırayla veritabanına kaydolmak üzere burada ilgili değişkenlere atanır.
                    //AspNetUser isimli tablodaki değerler buradan alınır
                };


                var result = await _userManager.CreateAsync(w, p.Password);
                //Bu kodu yeni kullanıcı oluşturmak için yazdık, yeni kullanıcı oluşması içinde
                //CreateAsync metodu kullanılır bu metod bir usera karşılık gelen
                //w ve formdan gelen p.passwordu kullanır.

                //Alt kısımda
                //Eğer geçerli ise yani kullanıcı oluşturduysa login/index isimli sayfa açılır - kullanıcının giriş yapacağı sayfaya yönlendirilir.
                //Identity mimarisine göre identity kütüphanesindeki metodlar asenkrondur bu nedenle asenkron olarak oluşturduk(Create Async......).
                //Asenkronik metod kullandığımız için  IActionResult async Task<IActionResult> şeklinde oluşturuldu.

                if (result.Succeeded) // buraya kadar sağlıyorsa logine git
                {
                    return RedirectToAction("Index", "Login");
                    //Kullanıcı kaydı başarılı ise  
                }
                else
                {
                    foreach (var item in result.Errors)//sağlamıyorsa hata ver
                        //Eğer yeni kullanıcı oluşturulmadıysa hata mesajı ver
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(p); //eğer sağlamıyorsa viewden aç
            //eğer returne geldiyse form içinde eksik var demektir
            //o zaman önceki yazılan değerler tekrar görünsün bu yüzden
            //view içinde p parametresini yazdık
            //kullanıcı onaylamadan önceki girdiği değerleri formda görür
        }
    }
}

