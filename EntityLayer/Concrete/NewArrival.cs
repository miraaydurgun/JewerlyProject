using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class NewArrival
    {
        [Key]
        public int NewArrivalid { get; set; }
        public string ArrivalImage { get; set; }
        public string ArrivalBtnTitle{ get; set; }
        public List<Home> Homes { get; set; }

    }
}
