using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CheckOut
    {
        [Key]
        public int CheckOutid { get; set; }
        public string COName { get; set; }
        public int COPhone { get; set; }
        public string COCity { get; set; }
        public string COAddress { get; set; }
    }
}
