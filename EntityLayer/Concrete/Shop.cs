using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Shop
    {
        [Key]
        public int Shopid { get; set; }
        public string ShopImage { get; set; }
        public string ShopHover { get; set; }
        public string ShopTitle { get; set; }
        public decimal ShopPrice { get; set; }
        public string ShopCartIcon { get; set; }
        public bool ShopStatus { get; set; }


        public int Shop_Singleid { get; set; }
        public Shop_Single Shop_Single { get; set; }

    }
}
