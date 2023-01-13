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
    public class ReviewManager : IReviewService
    {
        IReviewDal _reviewDal; //ekleme silme güncelleme işlemleri için altı kısımda kullanılacak generic değişkeni tanımlandı
        public ReviewManager(IReviewDal reviewDal)
        {
            _reviewDal = reviewDal;
        }
        public void TAdd(Review t)
        {
            _reviewDal.Insert(t);
        }

        public void TDelete(Review t)
        {
            _reviewDal.Delete(t);
        }

        public Review TGetByID(int id)
        {
            return _reviewDal.GetByID(id);
        }

        public List<Review> TGetList()
        {
            return _reviewDal.GetAll();
        }

        public void TUpdate(Review t)
        {
            _reviewDal.Update(t);
        }
    }
}
