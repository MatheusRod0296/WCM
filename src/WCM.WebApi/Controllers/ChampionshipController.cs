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
        public async Task<ResultTournament> Post([FromServices]IChampionshipService _movieService, [FromBody] string[] moviesId){ 
                return await _movieService.Championship(moviesId);
        }
    }
}