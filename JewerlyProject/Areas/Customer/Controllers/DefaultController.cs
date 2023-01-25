using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Win32;

namespace Core_Proje.Areas.Customer.Controllers
{ 
         [Authorize] //Sistem Authantice olması için bunu yapıyoruz yani kullanıcı login olmadan bu sayfa açılmayacak
    public class DefaultController : Controller
    {
        [Area("Customer")]
   
//        eğer area kullanıyorsak sayfanın Controller'ında attribute routing yapılmalı 
//-ve hangi area kullanılıyorsa belirtilmelidir, ayrıca area eklerken area'nın SacaffoldindReadMe sayfasındaki vermiş routing kodunu da
//-start up içindeki routing alanına eklememiz gerekir.
//-Register klasöründe Post Add view'den index geldi
        public IActionResult Index()
        {
            return View();
        }
    }
}
