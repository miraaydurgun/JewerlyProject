using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Login
    {
        [Key]
        public int Loginid { get; set; }
        public string LoginName { get; set; }
        public string LoginMail { get; set; }
        public int LoginPassword { get; set; }

    }
}
