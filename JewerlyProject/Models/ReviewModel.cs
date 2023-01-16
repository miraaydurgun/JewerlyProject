using EntityLayer.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace JewelryProject.Models
{
    public class ReviewModel
    {

        [Key]
        public int Reviewid { get; set; }
        public string ReviewName { get; set; }
        public string ReviewMail { get; set; }
        public bool ReviewMailStatus { get; set; }
        public string ReviewComment { get; set; }
        public DateTime ReviewDate { get; set; }
        public List<Home> Homes { get; set; }
        public List<Shop_Single> Shop_Singles { get; set; }



    }
}
