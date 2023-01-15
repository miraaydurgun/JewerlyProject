using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IHomeService : IGenericService<Home>
    {
        List<Home> GetHomeWithCampaign();
        List<Home> GetHomeWithNewArrival();
        List<Home> GetHomeWithReview();

    }
}
