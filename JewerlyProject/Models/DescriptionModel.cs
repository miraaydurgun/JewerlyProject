using EntityLayer.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JewelryProject.Models
{
    public class DescriptionModel
    {
        [Key]
        public int Descriptionid { get; set; }
        public string DescriptionTitle { get; set; }
        public string DescriptionComment { get; set; }

        public List<Shop_Single> Shop_Singles { get; set; }
    }
}
