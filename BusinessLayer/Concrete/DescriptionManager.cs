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
    public class DescriptionManager : IDescriptionService
    {
        IDescriptionDal _descriptionDal; //ekleme silme güncelleme işlemleri için altı kısımda kullanılacak generic değişkeni tanımlandı
        public DescriptionManager(IDescriptionDal descriptionDal)
        {
            _descriptionDal = descriptionDal;
        }
        public void TAdd(Description t)
        {
            _descriptionDal.Insert(t);
        }

        public void TDelete(Description t)
        {
            _descriptionDal.Delete(t);
        }

        public Description TGetByID(int id)
        {
            return _descriptionDal.GetByID(id);
        }

        public List<Description> TGetList()
        {
            return _descriptionDal.GetAll();

        }

        public void TUpdate(Description t)
        {
            _descriptionDal.Update(t);
        }
    }
}
