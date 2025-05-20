using Microsoft.AspNetCore.Mvc;
using AngelTech.PokemonApi.Models;
using AngelTech.PokemonApi.Services;

namespace AngelTech.PokemonApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PokemonController(IPokemonService pokemonService) : ControllerBase
{
    private readonly IPokemonService _pokemonService = pokemonService;

    // GET: api/pokemon
    [HttpGet]
    public ActionResult<IEnumerable<Pokemon>> GetAll()
    {
        return Ok(_pokemonService.GetAllPokemon());
    }

    // GET: api/pokemon/{id}
    [HttpGet("{id}")]
    public ActionResult<Pokemon> GetById(int id)
    {
        var pokemon = _pokemonService.GetAllPokemon().FirstOrDefault(p => p.Id == id);
        return pokemon == null ? NotFound() : Ok(pokemon);
    }
}
