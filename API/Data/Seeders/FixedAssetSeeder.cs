using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Seeders
{
    public class FixedAssetSeeder
    {
        public static async Task SeedFixedAssets(AppDbContext context)
        {
            if (await context.FixedAssets.AnyAsync()) return; // skip if data exists

             var fixedAssets = new List<FixedAsset>
            {
                new FixedAsset { Name = "Laptop", Category = "Electronics", Value = 1500.00m, PurchaseDate = DateTime.Now },
                new FixedAsset { Name = "Office Chair", Category = "Furniture", Value = 300.00m, PurchaseDate = DateTime.Now },
                new FixedAsset { Name = "Printer", Category = "Electronics", Value = 500.00m, PurchaseDate = DateTime.Now },
            };

            await context.FixedAssets.AddRangeAsync(fixedAssets);
            await context.SaveChangesAsync();
        }
    }
}