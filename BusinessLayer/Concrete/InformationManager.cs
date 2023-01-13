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
    public class InformationManager : IInformationService
    {
        IInformationDal _informationDal; //ekleme silme güncelleme işlemleri için altı kısımda kullanılacak generic değişkeni tanımlandı
        public InformationManager(IInformationDal informationDal)
        {
            _informationDal = informationDal;
        }
        public void TAdd(Information t)
        {
            _informationDal.Insert(t);
        }

        public void TDelete(Information t)
        {
            _informationDal.Delete(t);
        }

        public Information TGetByID(int id)
        {
            return _informationDal.GetByID(id);
        }

        public List<Information> TGetList()
        {
            return _informationDal.GetAll();
        }

        public void TUpdate(Information t)
        {
            _informationDal.Update(t);
        }
    }
}
