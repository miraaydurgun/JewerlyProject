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
    public class NewArrivalManager : INewArrivalService
    {
        INewArrivalDal _newarrivalDal; //ekleme silme güncelleme işlemleri için altı kısımda kullanılacak generic değişkeni tanımlandı
        public NewArrivalManager(INewArrivalDal newarrivalDal)
        {
            _newarrivalDal = newarrivalDal;
        }
        public void TAdd(NewArrival t)
        {
            _newarrivalDal.Insert(t);
        }

        public void TDelete(NewArrival t)
        {
            _newarrivalDal.Delete(t);
        }

        public NewArrival TGetByID(int id)
        {
            return _newarrivalDal.GetByID(id);
        }

        public List<NewArrival> TGetList()
        {
            return _newarrivalDal.GetAll();
        }

        public void TUpdate(NewArrival t)
        {
            _newarrivalDal.Update(t);
        }
    }
}
