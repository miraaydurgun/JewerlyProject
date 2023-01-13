using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ShopManager : IShopService
    {
        IShopDal _shopDal; //ekleme silme güncelleme işlemleri için altı kısımda kullanılacak generic değişkeni tanımlandı
        public ShopManager(IShopDal shopDal)
        {
            _shopDal = shopDal;
        }
        public void TAdd(Shop t)
        {
            _shopDal.Insert(t);
        }

        public void TDelete(Shop t)
        {
            _shopDal.Delete(t);
        }

        public Shop TGetByID(int id)
        {
            return _shopDal.GetByID(id);
        }

        public List<Shop> TGetList()
        {
            return _shopDal.GetAll();
        }

        public void TUpdate(Shop t)
        {
            _shopDal.Update(t);
        }
    }
}
