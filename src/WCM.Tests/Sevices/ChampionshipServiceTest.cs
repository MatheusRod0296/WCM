using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using Refit;
using WCM.WebApi.Services;
using Xunit;

namespace WCM.Tests.Sevices
{
    public class ChampionshipServiceTest
    {

        private readonly string _url = "http://copafilmes.azurewebsites.net/";
        
        [Theory, ClassData(typeof(ReturnSuccess))]
        public async Task ShouldReturnSuccessWhenExecuteChampionshipAsync(string[] ids)
        {
            var refitService = RestService.For<IMoviesService>(_url);

            var result = await new ChampionshipService(refitService).Play(ids);

            Assert.True(result.FirstPlace.Id == "tt4154756" && result.SecondPlace.Id == "tt3606756");
        }

        [Theory, ClassData(typeof(ReturnError))]
        public async Task ShouldReturnErrorWhenExecuteChampionshipAsync(string[] ids)
        {
            var refitService = RestService.For<IMoviesService>(_url);

            await Assert.ThrowsAsync<ArgumentException>(async () => await new ChampionshipService(refitService).Play(ids));
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