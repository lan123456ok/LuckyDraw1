namespace LuckyPromotion1.Model
{
    public class Rules
    {
        public int RuleId { get; set; }
        public string RuleName { get; set; }
        public int GiftCodeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Probality { get; set; }
        public DateTime Schedule { get;set }

    }
}
