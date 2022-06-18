namespace LuckyPromotion1.Model
{
    public class Barcodes
    {
        public int BarCodeId { get; set; }
        public string Code { get; set; }
        public byte[] Barcode { get; set; }
        public byte[] QRCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime ScannedDate { get; set; }

    }
}
