using Microsoft.EntityFrameworkCore;
using WebBanHang_Lab03.Data;
using WebBanHang_Lab03.Models;

namespace WebBanHang_Lab03.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                    new Product
                    {
                        Name = "Thần đồng đất việt tập 1",
                        Price = 4500,
                        ImageUrl = "https://lh3.googleusercontent.com/pw/AP1GczPrM_g0Zz_p9y2Y_o7y_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p" // Placeholder
                    },
                    new Product
                    {
                        Name = "Conan tập 1",
                        Price = 10000,
                        ImageUrl = "https://lh3.googleusercontent.com/pw/AP1GczPrM_g0Zz_p9y2Y_o7y_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p" // Placeholder
                    },
                    new Product
                    {
                        Name = "Conan",
                        Price = 9000,
                        ImageUrl = "https://lh3.googleusercontent.com/pw/AP1GczPrM_g0Zz_p9y2Y_o7y_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p_p" // Placeholder
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
