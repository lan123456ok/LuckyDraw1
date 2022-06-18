using System.ComponentModel.DataAnnotations;

namespace LuckyPromotion1.Model
{
    public class Campaigns
    {
        [Key] public int CampaignId { get; set; }

        public string ProgramName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreateedCode { get; set; }
        public int CustomerId { get; set; }

    }
}
