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
    public class Shop_SingleManager : IShop_SingleService
    {
        IShop_SingleDal _shop_singleDal; //ekleme silme güncelleme işlemleri için altı kısımda kullanılacak generic değişkeni tanımlandı
        public Shop_SingleManager(IShop_SingleDal shop_singleDal)
        {
            _shop_singleDal = shop_singleDal;
        }
        public void TAdd(Shop_Single t)
        {
            _shop_singleDal.Insert(t);
        }

        public void TDelete(Shop_Single t)
        {
            _shop_singleDal.Delete(t);
        }

        public Shop_Single TGetByID(int id)
        {
            return _shop_singleDal.GetByID(id);
        }

        public List<Shop_Single> TGetList()
        {
            return _shop_singleDal.GetAll();
        }

        public void TUpdate(Shop_Single t)
        {
            _shop_singleDal.Update(t);

        }
    }
}
