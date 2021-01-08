using System.Collections.Generic;

namespace WCM.WebApi.Models
{
    public class QuarterFinals : IGenerateMatches
    {
        public List<MatchModel> Execute(List<MovieModel> movies)
        {
            List<MatchModel> Matches = new List<MatchModel>();

            var countCrescent = 1;
            for (int i = 0; i < movies.Count / 2; i++)
                Matches.Add(new MatchModel(movies[i], movies[movies.Count - countCrescent++]));

            return Matches;
        }
    }
}