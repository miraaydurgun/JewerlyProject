using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Home
    {
        [Key]
        public int Homeid { get; set; }
        public string SliderImage { get; set; }
        public string SliderTitle { get; set; }
        public string SliderComment { get; set; }
        public int Campaignid { get; set; }
        public Campaign Campaign  { get; set; }
        public int NewArrivalid { get; set; }
        public NewArrival NewArrival { get; set; }
        public int Reviewid { get; set; }
        public Review Review { get; set; }




    }
}
