using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Refit;
using WCM.WebApi.Models;
using WCM.WebApi.Services;

namespace WCM.WebApi.Controllers
{
    [ApiController]
    [Route("v1/[Controller]")]
    public class MovieController: Controller
    {
       
        [HttpGet]
        public async Task<IEnumerable<MovieModel>> Get([FromServices]IMoviesService _movieService)
                => await _movieService.GetMovies();
        
    }
}