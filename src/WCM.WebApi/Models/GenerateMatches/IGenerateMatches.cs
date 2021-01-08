using System.Collections.Generic;

namespace WCM.WebApi.Models
{
    public interface IGenerateMatches
    {
         List<MatchModel> Execute(List<MovieModel> movies);
    }
}