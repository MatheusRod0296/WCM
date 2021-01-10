using System;
using System.Collections.Generic;

namespace WCM.WebApi.Models
{
    public class Finals : IGenerateMatches
    {
        public List<MatchModel> Execute(List<MovieModel> movies)
        {
            if(movies == null || (movies.Count != 4 && movies.Count != 2 ))
                throw new ArgumentException("Número de filmes inválidos para as finais.");
                
            List<MatchModel> Matches = new List<MatchModel>();

            for (int i = 0; i < movies.Count; i += 2)
                Matches.Add(new MatchModel(movies[i], movies[i+1]));

            return Matches;
        }
    }
}