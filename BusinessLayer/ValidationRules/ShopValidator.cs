using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ShopValidator:AbstractValidator<Shop>
    {
        public ShopValidator()
        {
            //Rulefor metodu ile form içerisinde değer girişinde etki ve kontrol tanımlamaları yaparız.
            RuleFor(x => x.ShopImage).NotEmpty().WithMessage("Image Url alanı  boş geçilemez.");
            RuleFor(x => x.ShopHover).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
            RuleFor(x => x.ShopTitle).NotEmpty().WithMessage("Ürün adı boş geçilemez.");
            RuleFor(x => x.ShopPrice).NotEmpty().WithMessage("Image Url alanı  boş geçilemez.");

            RuleFor(x => x.ShopPiece).NotEmpty().WithMessage("");
            RuleFor(x => x.ShopCartIcon).NotEmpty().WithMessage("İkon boş geçilemez");
            RuleFor(x => x.ShopStatus).NotEmpty().WithMessage("İkon belirleme boş geçilemez");

        }
    }
}
