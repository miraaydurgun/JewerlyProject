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
    public class CheckOutManager : ICheckOutService
    {

        ICheckOutDal _checkoutDal; //ekleme silme güncelleme işlemleri için altı kısımda kullanılacak generic değişkeni tanımlandı
        public CheckOutManager(ICheckOutDal checkoutDal)
        {
            _checkoutDal = checkoutDal;
        }
        public void TAdd(CheckOut t)
        {
            _checkoutDal.Insert(t);
        }

        public void TDelete(CheckOut t)
        {
            _checkoutDal.Delete(t);
        }

        public CheckOut TGetByID(int id)
        {
            return _checkoutDal.GetByID(id);
        }

        public List<CheckOut> TGetList()
        {
            return _checkoutDal.GetAll();
        }

        public void TUpdate(CheckOut t)
        {
            _checkoutDal.Update(t);
        }
    }
}
