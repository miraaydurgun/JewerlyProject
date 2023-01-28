using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ExperienceValidator:AbstractValidator<Shop>
    {
        public ExperienceValidator()
        {
            //Rulefor metodu ile form içerisinde değer girişinde etki ve kontrol tanımlamaları yaparız.
            RuleFor(x => x.ShopTitle).NotEmpty().WithMessage("Ürün Adı alanı boş geçilemez.");
            RuleFor(x => x.ShopHover).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
            RuleFor(x => x.ShopPrice).NotEmpty().WithMessage("Fiyat alanı boş geçilemez.");
            RuleFor(x => x.ShopImage).NotEmpty().WithMessage("Image Url alanı  boş geçilemez.");
            RuleFor(x => x.ShopPiece).NotEmpty().WithMessage("Adet alanı  boş geçilemez.");


            RuleFor(x => x.ShopTitle).MinimumLength(3).WithMessage("Ürün Adı için en az 3 karakter girmelisiniz");
            RuleFor(x => x.ShopTitle).MaximumLength(30).WithMessage("Ürün Adı için en fazla 30 karakter girmelisiniz");

        }
    }
}
