using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IHomeDal : IGenericDal<Home>
    {
        List<Home> GetListWithCampaign();
        List<Home> GetListWithNewArrival();
        List<Home> GetListWithReview();

    }
}
