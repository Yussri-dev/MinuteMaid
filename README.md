MinuteMeals (20p)
Omschrijving
Een klant vraagt je om een website te maken die 10 recepten kan tonen. Er is geen beheer nodig
van de recepten, enkel weergave
Core
Model
public class Recipe
{
public required string Name { get; set; }
public required string Ingredients { get; set; }
public required string Steps { get; set; }
public int CookingTimeInMinutes { get; set; }
}
Algemeen (5p)
Voeg de nodige eigenschappen toe aan het model om het werkbaar te maken.
Gebruik ASP.net Core.
Verzorg de opmaak van de website.
Let op je naamgeving.
Maak gebruik van een EntityFramework InMemory database.
Maak gebruik van Dependency Injection.
Zorg ervoor dat er minstens 10 recepten in de database zitten bij het opstarten. Je mag
generatieve AI gebruiken om deze lijst te genereren.
Home pagina (5p)
Op de home pagina verschijnt een lijst met alle recepten. Gebruik hiervoor geen tabel.
Enkel de naam van het gerecht en de bereidingstijd mag getoond worden.
Wanneer je klikt op het gerecht, navigeer je naar het detailscherm van het gerecht.
Gebruik een partial view om één gerecht te tonen.
Recipe Detail (5p)
Op het detailscherm van het gerecht vind je opnieuw de naam en de bereidingstijd, maar ook de
ingrediënten en de stappen.
Navigeren naar een detail pagina kan je doen door asp-route-id te gebruiken in de hyperlink. Zorg
voor de correcte parameter in je Details action
Zorg ervoor dat je kan terug navigeren naar de hoofdpagina.
Recipe beheer lijst (5p)
Maak een aparte Recipes menuknop die navigeert naar een lijst van recepten in een aparte
controller.
Deze lijst is een tabel met standaard bootstrap opmaak.
Enkel de naam en de bereidingstijd is zichtbaar.
Zorg ervoor dat elke tabelrij getoond wordt door middel van een Partial View.
