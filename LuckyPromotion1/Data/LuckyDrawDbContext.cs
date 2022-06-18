using LuckyPromotion1.Model;
using Microsoft.EntityFrameworkCore;

namespace LuckyPromotion1.Data
{
    public class LuckyDrawDbContext : DbContext
    {
       public LuckyDrawDbContext(DbContextOptions<LuckyDrawDbContext> options)
            : base(options)
        {}

        public DbSet<LuckyDrawDbContext> Account { get; set; }
        public DbSet<LuckyDrawDbContext> Barcodes { get; set; }
        public DbSet<LuckyDrawDbContext> CampaignDetails { get; set; }
        public DbSet<LuckyDrawDbContext> Campaign { get; set; }
        public DbSet<LuckyDrawDbContext> Customers { get; set; }
        public DbSet<LuckyDrawDbContext> GiftCode { get; set; }
        public DbSet<LuckyDrawDbContext> Gifts { get; set; }
        public DbSet<LuckyDrawDbContext> Rules { get; set; }
    }
}
