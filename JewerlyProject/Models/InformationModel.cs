using EntityLayer.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JewelryProject.Models
{
    public class InformationModel
    {
        [Key]
        public int Informationid { get; set; }
        public string InformationTitle { get; set; }
        public string InformationComment { get; set; }
        public List<Shop_Single> Shop_Singles { get; set; }
    }
}
