using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Review
    {
        [Key]
        public int Reviewid { get; set; } //reply kalkacak ve image
        public string ReviewName { get; set; }
        public string ReviewMail { get; set; }
        public bool ReviewMailStatus { get; set; }
        public string ReviewComment { get; set; }
        public DateTime ReviewDate { get; set; }
        //butona onclick
        public string UserImage { get; set; }

        public List<Home> Homes { get; set; }

        public List<Shop_Single> Shop_Singles { get; set; }




    }
}
