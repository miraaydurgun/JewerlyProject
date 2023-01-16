using EntityLayer.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JewelryProject.Models
{
    public class CampaignModel
    {
        [Key]
        public int Campaignid { get; set; }
        public string CampaignImage { get; set; }
        public string CampaignComment { get; set; }
        public string CampaignTitle { get; set; }
        public List<Home> Homes { get; set; }
    }
}
