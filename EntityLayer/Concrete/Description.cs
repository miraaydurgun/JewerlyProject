using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Description
    {
        [Key]
        public int Descriptionid { get; set; }
        public string DescriptionTitle { get; set; }
        public string DescriptionComment { get; set; }

        public List<Shop_Single> Shop_Singles { get; set; }

    }
}
