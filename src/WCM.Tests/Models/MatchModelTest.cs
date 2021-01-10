using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WCM.WebApi.Models;
using Xunit;

namespace WCM.Tests.Models
{
    public class MatchModelTest
    {

        [Theory, ClassData(typeof(ReturnSuccess))]
        public void ShouldReturnSuccessWhenCreateMacthModel(IEnumerable<MovieModel> movies)
        {

            var matchModel = new MatchModel(movies.First(), movies.Skip(1).First());
            Assert.True(matchModel.Winner.Id == "2");
        }

        [Theory, ClassData(typeof(ReturnError))]
        public void ShouldReturnErrorWhenCreateMacthModel(IEnumerable<MovieModel> movies)
        {
            Assert.Throws<ArgumentException>(() => new MatchModel(movies.First(), movies.Skip(1).First()));
        }

    }

    public class ReturnSuccess : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
            {
                 new object[] {
                    new Collection<MovieModel>
                        {
                            new MovieModel("1", "Titulo", 2021, 10),
                            new MovieModel("2", "A Titulo", 2021, 10),
                        }
                },
                new object[] {
                    new Collection<MovieModel>
                        {
                            new MovieModel("1", "A Titulo", 2021, 10),
                            new MovieModel("2", "0 Titulo", 2021, 10),
                        }
                },
                new object[] {
                    new Collection<MovieModel>
                        {
                            new MovieModel("1", "Titulo", 2021, 9),
                            new MovieModel("2", "Titulo 2", 2021, 9.4)
                        }
                },
                new object[] {
                    new Collection<MovieModel>
                        {
                            new MovieModel("1", "A Titulo", 2021, 9.1),
                            new MovieModel("2", "Titulo 2", 2021, 9.2)
                        }
                }
            };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

    public class ReturnError : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { 
                new Collection<MovieModel>
                {
                    new MovieModel("1", "Teste", 2021, 10),
                    null
                }

            },
            new object[] { 
                new Collection<MovieModel>
                {

                        null,
                        new MovieModel("1", "Teste", 2021, 10)

                }
            },
            new object[] { 
                new Collection<MovieModel>
                {

                   null,
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