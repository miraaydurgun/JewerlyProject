using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Information 
    {
        [Key]
        public int Informationid { get; set; }
        public string InformationTitle { get; set; }
        public string InformationComment { get; set; }
        public List<Shop_Single> Shop_Singles { get; set; }

    }
}
