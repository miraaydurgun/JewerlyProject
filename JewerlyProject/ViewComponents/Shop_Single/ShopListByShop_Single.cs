using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using JewelryProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

namespace JewelryProject.ViewComponents.Shop_Single
{
    public class ShopListByShop_Single : ViewComponent
    {
        ShopManager sm = new ShopManager(new EfShopRepository());
        public IViewComponentResult Invoke()
        {
            var values = sm.TGetList();
            return View(values);
        }
    }
}
