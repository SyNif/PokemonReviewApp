﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IpokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExist(int pokeId);

    }
}
