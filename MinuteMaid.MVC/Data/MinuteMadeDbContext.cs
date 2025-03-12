using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using MinuteMaid.MVC.Models;

namespace MinuteMaid.MVC.Data
{
    public class MinuteMadeDbContext : DbContext
    {
        public MinuteMadeDbContext(DbContextOptions<MinuteMadeDbContext> options) : base(options) { }
        public DbSet<Recipe> Recipes { get; set; }

        public void SeedDatabase()
        {
            if (!Recipes.Any())
            {
                Recipes.AddRange(new List<Recipe>
            {
                new() { Name = "Spaghetti Bolognese", Ingredients = "Pasta, Gehakt, Tomatensaus", Steps = "Kook pasta, bak gehakt, voeg saus toe", CookingTimeInMinutes = 30 },
                new() { Name = "Pannenkoeken", Ingredients = "Bloem, Melk, Eieren", Steps = "Mix ingrediënten en bak", CookingTimeInMinutes = 20 },
                new() { Name = "Caesar Salad", Ingredients = "Sla, Kip, Croutons, Kaas", Steps = "Meng alles samen", CookingTimeInMinutes = 15 },
                new() { Name = "Omelet", Ingredients = "Eieren, Kaas, Melk", Steps = "Klop eieren, bak in pan", CookingTimeInMinutes = 10 },
                new() { Name = "Lasagne", Ingredients = "Lasagnebladen, Gehakt, Bechamelsaus", Steps = "Laagjes maken en bakken", CookingTimeInMinutes = 45 },
                new() { Name = "Tomatensoep", Ingredients = "Tomaten, Bouillon, Kruiden", Steps = "Kook tomaten, mix en serveer", CookingTimeInMinutes = 25 },
                new() { Name = "Biefstuk met friet", Ingredients = "Biefstuk, Aardappelen, Zout", Steps = "Bak biefstuk en friet", CookingTimeInMinutes = 40 },
                new() { Name = "Pizza Margherita", Ingredients = "Deeg, Tomatensaus, Mozzarella", Steps = "Maak bodem, beleg en bak", CookingTimeInMinutes = 30 },
                new() { Name = "Stoofvlees", Ingredients = "Rundvlees, Bier, Ui", Steps = "Sudderen tot mals", CookingTimeInMinutes = 120 },
                new() { Name = "Gehaktballen", Ingredients = "Gehakt, Ei, Paneermeel", Steps = "Meng, rol en bak", CookingTimeInMinutes = 35 }
            });
                SaveChanges();
            }
        }
    }
}
