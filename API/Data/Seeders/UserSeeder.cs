using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Seeders
{
    public class UserSeeder
    {
        public static async Task SeedUsers(AppDbContext context)
        {
            if (await context.Users.AnyAsync()) return; // skip if data exists

            var users = new List<AppUser>
            {
                new AppUser { FullName = "Randy", EmailAddress = "randy@test.com" },
                new AppUser { FullName = "Migs", EmailAddress = "migs@test.com" },
                new AppUser { FullName = "Jabs", EmailAddress = "jabs@test.com" },
                new AppUser { FullName = "Jim", EmailAddress = "jim@test.com" },
            };

            await context.Users.AddRangeAsync(users);
            await context.SaveChangesAsync();
        }
    }
}