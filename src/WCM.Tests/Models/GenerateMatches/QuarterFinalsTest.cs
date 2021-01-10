using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WCM.WebApi.Models;
using Xunit;

namespace WCM.Tests.Models.GenerateMatches
{
    public class QuarterFinalsTest
    {
        [Theory, ClassData(typeof(ReturnSuccess))]
        public void ShouldReturnSuccessWhenGenerateQuarterFinal(IEnumerable<MovieModel> movies)
        {
            var matches = new QuarterFinals().Execute(movies.ToList());

            Assert.True(matches[0].Winner.Id == "1" &&
                      matches[0].Loser.Id == "8" &&
                      matches[1].Winner.Id == "2" &&
                      matches[1].Loser.Id == "7" &&
                      matches[2].Winner.Id == "3" &&
                      matches[2].Loser.Id == "6" &&
                      matches[3].Winner.Id == "4" &&
                      matches[3].Loser.Id == "5");                        
          
        }

        [Theory, ClassData(typeof(ReturnError))]
        public void ShouldReturnErrorWhenGenerateQuarterFinal(IEnumerable<MovieModel> movies)
        {
            Assert.Throws<ArgumentException>(() => new QuarterFinals().Execute(movies.ToList()));
        }
    }

    public class ReturnSuccess : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {
                new Collection<MovieModel>
                    {
                        new MovieModel("1", "filme 1", 2021, 10),
                        new MovieModel("2", "filme 2", 2021, 10),
                        new MovieModel("3", "filme 3", 2021, 10),
                        new MovieModel("4", "filme 4", 2021, 10),
                        new MovieModel("5", "filme 5", 2021, 10),
                        new MovieModel("6", "filme 6", 2021, 10),
                        new MovieModel("7", "filme 7", 2021, 10),
                        new MovieModel("8", "filme 8", 2021, 10)                      
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
                new Collection<MovieModel>
                    {
                        new MovieModel("1", "filme 1", 2021, 10),
                        new MovieModel("2", "filme 2", 2021, 10),
                        new MovieModel("3", "filme 3", 2021, 10),
                        new MovieModel("4", "filme 4", 2021, 10),
                        new MovieModel("5", "filme 5", 2021, 10),
                        new MovieModel("6", "filme 6", 2021, 10),
                        new MovieModel("7", "filme 7", 2021, 10)                   
                      
                    }
            },

            new object[] {
                new Collection<MovieModel>()
                    
            },

            new object[] {
                new Collection<MovieModel>
                    {
                        null                 
                      
                    }
            },

                    
        };

        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }

        
    }

    
}