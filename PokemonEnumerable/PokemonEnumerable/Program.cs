using System;

namespace PokemonEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemones pokemones = new Pokemones();
            foreach (Pokemon pokemon in pokemones)
            {
                Console.WriteLine($"El nombre del pokemon es {pokemon.Name} y su poder es de: {pokemon.Poder}");
            }
        }
    }
}
