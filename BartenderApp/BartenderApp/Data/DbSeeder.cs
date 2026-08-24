using BartenderApp.Models;

namespace BartenderApp.Data;

public class DbSeeder
{
    public static void Seed(AppDbContext context)
    {
        // Only seeds if the table is empty
        if (context.Drinks.Any()) return;

        // ID, name, description, price, ordered at
        context.Drinks.AddRange(
            new Drink { Name = "Widget A", Description = "A great widget", Price = 9.99m },
            new Drink { Name = "Widget B", Description = "An even better widget", Price = 19.99m },
            new Drink { Name = "Widget C", Description = "The best widget", Price = 29.99m }
        );

        context.SaveChanges();
    }

}