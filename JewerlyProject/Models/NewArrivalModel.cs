using EntityLayer.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JewelryProject.Models
{
    public class NewArrivalModel
    {

        [Key]
        public int NewArrivalid { get; set; }
        public string ArrivalImage { get; set; }
        public string ArrivalBtnTitle { get; set; }
        public List<Home> Homes { get; set; }
    }
}
