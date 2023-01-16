using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace JewelryProject.ViewComponents.Home
{
    public class CampaignListByHome:ViewComponent
    {
        CampaignManager hm = new CampaignManager(new EfCampaignRepository());
        public IViewComponentResult Invoke()
        {
            var values = hm.TGetList();
            return View(values);
        }
    }
}
