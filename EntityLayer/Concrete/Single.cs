using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Single
    {
        [Key]
        public int Singleid { get; set; }
        public string SingleImage { get; set; }
        public string SingleTitle { get; set; }
        public string SinglePrice { get; set; }
        public string SingleColor { get; set; }
        public bool UseState { get; set; }

        //usestate
        //public int ShopReview { get; set; }
        //sayfanın tamamınının datası ygapılmadı

    }
}
