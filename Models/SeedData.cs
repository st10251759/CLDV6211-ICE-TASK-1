using CarSales.Data;
using Microsoft.EntityFrameworkCore;

namespace CarSales.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CarSalesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CarSalesContext>>()))
            {
                // Look for any cars.
                if (context.Sales.Any())
                {
                    return;   // DB has been seeded
                }
                context.Sales.AddRange(
                    new Sales
                    {
                        Make = "Toyota",
                        Model = "Corolla",
                        Price = 15000.00M,
                        DateListed = DateTime.Parse("2024-03-19")
                    },
                    new Sales
                    {
                        Make = "Honda",
                        Model = "Civic",
                        Price = 16000.00M,
                        DateListed = DateTime.Parse("2024-03-20")
                    },
                    new Sales
                    {
                        Make = "Ford",
                        Model = "F-150",
                        Price = 35000.00M,
                        DateListed = DateTime.Parse("2024-03-21")
                    },
                    new Sales
                    {
                        Make = "Chevrolet",
                        Model = "Camaro",
                        Price = 45000.00M,
                        DateListed = DateTime.Parse("2024-03-22")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
