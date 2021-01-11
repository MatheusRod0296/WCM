using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using WCM.WebApi.Services;
using Xunit;
using Moq;
using WCM.WebApi.Models;

namespace WCM.Tests.Sevices
{
    public class ChampionshipServiceTest
    {

        private readonly List<MovieModel> _movies = new List<MovieModel>{
                new MovieModel("tt3606756","Os Incríveis 2", 2018, 8.5 ),
                new MovieModel("tt4881806","Jurassic World: Reino Ameaçado", 2018, 6.7 ),
                new MovieModel("tt5164214","Oito Mulheres e um Segredo", 2018, 6.3 ),
                new MovieModel("tt7784604","Hereditário", 2018, 7.8 ),
                new MovieModel("tt4154756","Vingadores: Guerra Infinita", 2018, 8.8 ),
                new MovieModel("tt5463162","Deadpool 2", 2018, 8.1),
                new MovieModel("tt3778644","Han Solo: Uma História Star Wars", 2018, 7.2 ),
                new MovieModel("tt3501632","Thor: Ragnarok", 2018, 7.9 )
                
            };
        
        [Theory, ClassData(typeof(ReturnSuccess))]
        public async Task ShouldReturnSuccessWhenExecuteChampionshipAsync(string[] ids)
        {
            var refitService = new Mock<IMoviesService>();
            refitService.Setup(m => m.GetMovies()).ReturnsAsync(_movies);     

            var result = await new ChampionshipService(refitService.Object).Play(ids);

            Assert.True(result.FirstPlace.Id == "tt4154756" && result.SecondPlace.Id == "tt3606756");
        }

        [Theory, ClassData(typeof(ReturnError))]
        public async Task ShouldReturnErrorWhenExecuteChampionshipAsync(string[] ids)
        {
             var refitService = new Mock<IMoviesService>();
            refitService.Setup(m => m.GetMovies()).ReturnsAsync(_movies);    

            await Assert.ThrowsAsync<ArgumentException>(async () => await new ChampionshipService(refitService.Object).Play(ids));
        }
    }

    public class ReturnSuccess : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
              new object[] {
                new string[]{
                    "tt3606756",
                    "tt4881806",
                    "tt5164214",
                    "tt7784604",
                    "tt4154756",
                    "tt5463162",
                    "tt3778644",
                    "tt3501632"
                }
            }
        };

        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }


    }

    public class ReturnError : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
              new object[] {
                new string[]{
                    "tt3606756",
                    "tt4881806",
                    "tt5164214",
                    "tt7784604",
                    "tt4154756",
                    "tt5463162",
                    "tt3778644",
                    "000000000"
                }
            },
             new object[] {
                 Array.Empty<string>()
            }
        };

        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }


    }

}