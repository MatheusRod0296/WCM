using System;
using System.Collections.Generic;

namespace WCM.WebApi.Models
{
    public class QuarterFinals : IGenerateMatches
    {
        public List<MatchModel> Execute(List<MovieModel> movies)
        {
            if(movies == null || movies.Count != 8)
                throw new ArgumentException("Número de filmes inválidos para as quartas de finais.");

            List<MatchModel> Matches = new List<MatchModel>();
            
            var countCrescent = 1;
            for (int i = 0; i < movies.Count / 2; i++)
                Matches.Add(new MatchModel(movies[i], movies[movies.Count - countCrescent++]));

            return Matches;
        }
    }
}