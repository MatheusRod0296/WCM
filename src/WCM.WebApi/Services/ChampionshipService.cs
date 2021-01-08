using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WCM.WebApi.Helpers;
using WCM.WebApi.Models;

namespace WCM.WebApi.Services
{
    public class ChampionshipService : IChampionshipService
    {
        private readonly IMoviesService _movieService;

        public ChampionshipService(IMoviesService movieService)
             => _movieService = movieService;

        public async Task<ResultTournament> Championship(string[] moviesId)
        {
            var movies = await MoviesFilterByIds.GetMoviesById(_movieService, moviesId);
            if (movies.Count == 8)
            {
                movies.Sort((x, y) => string.Compare(x.Titulo, y.Titulo));
                var match = ExecuteChampionship(movies);
                return new ResultTournament(match.Winner, match.Loser);
            }
            throw new ArgumentException("Numero de Filmes invalido, é necessario 8 filmes");
        }

        private MatchModel ExecuteChampionship(List<MovieModel> movies)
        {  
            IGenerateMatches generator = GenerateFactory.CreateGenerator(movies.Count);
            var matches = generator.Execute(movies);

            var winners = matches.Select(x => x.Winner).ToList();
            if (winners.Count > 1)
                return ExecuteChampionship(winners);

            return matches.First();
        }
    }
}