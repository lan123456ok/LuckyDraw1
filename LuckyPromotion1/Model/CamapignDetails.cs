namespace LuckyPromotion1.Model
{
    public class CamapignDetails
    {
        public int CamapignId { get; set; }
        public string CamapignName { get; set; }
        public Type CampaginType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int ActivatedCode { get; set; }
        public int Giftquantity { get; set; }
        public int ScannedCode { get;set }
        public int Spinned { get; set; }
        public int Winner { get; set; }
        public int BarCodeId { get; set; }
        public int GiftCodeId { get; set; }

    }

}
