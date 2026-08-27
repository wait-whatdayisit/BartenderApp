using BartenderApp.Models;

namespace BartenderApp.Data;

public static class DbSeeder
{
    public static void Seed(AppDbContext context)
    {
        // Only seeds if the table is empty
        if (context.Drinks.Any()) return;

        // ID, name, description, price, ordered at
        context.Drinks.AddRange(
            new Drink { Name = "Old Fashioned", Description = "Whiskey, sugar, and bitters.", Price = 6.99m, OrderedAt =  DateTime.Now.ToString("h:mm:ss tt")},
            new Drink { Name = "Dry Martini", Description = "Gin, vermouth, and orange bitters.", Price = 8.99m, OrderedAt =  DateTime.Now.ToString("h:mm:ss tt")},
            new Drink { Name = "Margarita", Description = "Tequila, orange liqueur, and lime juice.", Price = 9.99m, OrderedAt =  DateTime.Now.ToString("h:mm:ss tt")},
            new Drink { Name = "Espresso Martini", Description = "Vodka, espresso, and coffee liqueur.", Price = 5.99m, OrderedAt =  DateTime.Now.ToString("h:mm:ss tt")},
            new Drink { Name = "Mojito", Description = "Rum, lime, mint, and sugar.", Price = 7.99m, OrderedAt =  DateTime.Now.ToString("h:mm:ss tt")},
            new Drink { Name = "Bloody Mary", Description = "Vodka, tomato juice, hot sauce, and lemon juice.", Price = 10.99m, OrderedAt =  DateTime.Now.ToString("h:mm:ss tt")},
            new Drink { Name = "Piña Colada", Description = "Rum, coconut, pineapple, and lime.", Price = 8.99m, OrderedAt =  DateTime.Now.ToString("h:mm:ss tt")},
            new Drink { Name = "El Diablo", Description = "Tequila, crème de cassis, lime juice, and ginger.", Price = 12.99m, OrderedAt =  DateTime.Now.ToString("h:mm:ss tt")},
            new Drink { Name = "Sidecar", Description = "Cognac, orange liqueur, and lemon juice.", Price = 9.99m, OrderedAt =  DateTime.Now.ToString("h:mm:ss tt")},
            new Drink { Name = "Caipirinha", Description = "Cachaça, lime juice, and sugar.", Price = 7.99m, OrderedAt =  DateTime.Now.ToString("h:mm:ss tt")}
        );

        context.SaveChanges();
    }

}