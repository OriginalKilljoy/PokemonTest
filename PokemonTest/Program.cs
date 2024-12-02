using PokemonTest;

var pokemon1 = new Pokemon("Pikachu", 100, 75, "Electric");
var pokemon2 = new Pokemon("Bulbasaur", 150, 125, "Grass");

Console.WriteLine(pokemon1.GetName());
Console.WriteLine(pokemon2.GetName());
pokemon1.PrintStats();
pokemon2.PrintStats();