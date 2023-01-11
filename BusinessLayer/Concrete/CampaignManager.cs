using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CampaignManager : ICampaignService
    {
        //
        ICampaignDal _campaignDal; //ekleme silme güncelleme işlemleri için altı kısımda kullanılacak generic değişkeni tanımlandı
        public CampaignManager(ICampaignDal campaignDal)
        {
            _campaignDal = campaignDal;
        }

        public void TAdd(Campaign t)
        {
            _campaignDal.Insert(t);
        }

        public void TDelete(Campaign t)
        {
            _campaignDal.Delete(t);
        }

        public Campaign TGetByID(int id)
        {
            return _campaignDal.GetByID(id);
        }

        public List<Campaign> TGetList()
        {
            return _campaignDal.GetAll();
        }

        public void TUpdate(Campaign t)
        {
            _campaignDal.Update(t);
        }
    }
}
