using System.Collections.Generic;
using System.Threading.Tasks;
using WCM.WebApi.Models;

namespace WCM.WebApi.Services
{
    public interface IChampionshipService
    {
         Task<ResultTournament> Championship(string[] moviesId);

    }
}