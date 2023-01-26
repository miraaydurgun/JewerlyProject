using System.ComponentModel.DataAnnotations;

namespace JewelryProject.Areas.Customer.Controllers
{
    public class UserLoginViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "\"Lütfen Şifre Giriniz")]
        public string Password { get; set; }

    }
}
