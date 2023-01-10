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
        public string SliderComment { get; set; }
        public string SliderTitle { get; set; }

        //campaign ve new arrivals geitrrelecek!

    }
}
