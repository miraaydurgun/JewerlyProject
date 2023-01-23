using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CheckOut
    {
        [Key]
        public int CheckOutid { get; set; }
        public int COName { get; set; }
        public int COPhone { get; set; }
        public int COCountry { get; set; }
        public int COCity { get; set; }
        public int COAddressName { get; set; }
        public int COAddress { get; set; }

        public int COButton { get; set; }
        public int COPriceTotal { get; set; }

        public int Shop_Singleid { get; set; }
        public Shop_Single Shop_Single { get; set; }
        public List<Shop_Single> Shop_Singles { get; set; }

    }
}
