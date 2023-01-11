using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Shop_Single
    {
        [Key]
        public int Shop_Singleid { get; set; }
       
        public string SingleColor { get; set; }
        public bool SingleStatus { get; set; }

        public List<Shop> Shops { get; set; }

        public int Descriptionid { get; set; }
        public Description Description { get; set; }
        public int Reviewid { get; set; }
        public Review Review { get; set; }
        public int Informationid { get; set; }
        public Information Information { get; set; }



    }
}
