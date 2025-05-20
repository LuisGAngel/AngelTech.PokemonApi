using AngelTech.PokemonApi.Models;

namespace AngelTech.PokemonApi.Services;

/// <summary>
/// Service for managing Pokémon data. 
/// In the future, this will fetch from the database. 
/// For now, it returns a static list.
/// </summary>
public class PokemonService : IPokemonService
{
    private static readonly IEnumerable<Pokemon> _pokemonList =
    [
        new Pokemon(1, "Bulbasaur", "Grass/Poison"),
        new Pokemon(2, "Charmander", "Fire"),
        new Pokemon(3, "Squirtle", "Water")
    ];

    /// <summary>
    /// Returns all Pokémon.
    /// </summary>
    public IEnumerable<Pokemon> GetAllPokemon()
    {
        return _pokemonList;
    }
}
