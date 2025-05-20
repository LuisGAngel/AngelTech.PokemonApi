using AngelTech.PokemonApi.Models;

namespace AngelTech.PokemonApi.Services;

/// <summary>
/// Interface for PokemonService.
/// </summary>
public interface IPokemonService
{
    /// <summary>
    /// Returns all Pokémon.
    /// </summary>
    public IEnumerable<Pokemon> GetAllPokemon();
}
