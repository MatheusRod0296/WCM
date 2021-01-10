using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WCM.WebApi.Models;
using WCM.WebApi.Services;

namespace WCM.WebApi.Controllers
{
    [ApiController]
    [Route("v1/[Controller]")]
    public class ChampionshipController : Controller
    {
        [HttpPost]
        public async Task<ResultChampionship> Post([FromServices]IChampionshipService _movieService, [FromBody] string[] moviesId)
                => await _movieService.Play(moviesId);
       
    }
}