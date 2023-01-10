using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int Aboutid { get; set; }
        public string AboutDescription { get; set; }
        public string AboutIcon { get; set; }
        public string IconTitle { get; set; }
        public string IconDescription { get; set; }

    }
}
