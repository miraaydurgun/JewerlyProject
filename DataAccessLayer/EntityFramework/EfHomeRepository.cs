using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfHomeRepository : GenericRepository<Home>, IHomeDal
    {
        public List<Home> GetListWithCampaign()
        {
            using(var c=new Context())
            {
                return c.Homes.Include(x=>x.Campaign).ToList();
            }
        }

        public List<Home> GetListWithNewArrival()
        {
            using (var c = new Context())
            {
                return c.Homes.Include(x => x.Campaign).ToList();
            }
        }

        public List<Home> GetListWithReview()
        {
            using (var c = new Context())
            {
                return c.Homes.Include(x => x.Campaign).ToList();
            }
        }
    }
}
