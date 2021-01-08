using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WCM.WebApi.Models;
using WCM.WebApi.Services;

namespace WCM.WebApi.Helpers
{
    public static class MoviesFilterByIds
    {
        public static async Task<List<MovieModel>> GetMoviesById(IMoviesService _movieService, string[] moviesId)
        {
            var resultMovies = await _movieService.GetMovies();
            return resultMovies.Where(x => moviesId.Contains(x.Id)).ToList();
        }
    }
}