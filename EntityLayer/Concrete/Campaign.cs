using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Campaign
    {
        [Key]
        public int Campaignid { get; set; }
        public string CampaignImage { get; set; }
        public string CampaignComment { get; set; }
        public string CampaignTitle { get; set; }
        public List<Home> Homes { get; set; }

    }
}
