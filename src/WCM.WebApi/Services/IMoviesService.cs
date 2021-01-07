using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using WCM.WebApi.Models;

namespace WCM.WebApi.Services
{
    public interface IMoviesService
    {
        [Get("/api/filmes")]
        Task<List<MovieModel>> GetMovies();
    }
}