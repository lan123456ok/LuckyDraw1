namespace LuckyPromotion1.Model
{
    public class GiftCode
    {
        public int GiftCodeId { get; set; }
        public int GiftId { get; set; }
        public string Code { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CodeUseLimit {get;set;}
        public int Used { get; set; }
    }
}
