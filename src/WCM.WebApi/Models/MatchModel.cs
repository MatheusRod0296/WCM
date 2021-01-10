
using System;

namespace WCM.WebApi.Models
{
    public class MatchModel
    {
        public MatchModel(MovieModel movieOne, MovieModel movieTwo){
            if(movieOne == null || movieTwo == null)
                throw new ArgumentException("Os Filmes não podem ser nulos.");

             Play(movieOne, movieTwo);
        }
           
        public MovieModel Winner { get; private set; }
        public MovieModel Loser { get; private set; }

        private void Play(MovieModel movieOne, MovieModel movieTwo)
        {
            if (movieOne.Nota.Equals(movieTwo.Nota))
                Tiebreaker(movieOne, movieTwo);
            else
            {
                SetWinner(movieOne.Nota > movieTwo.Nota ? movieOne : movieTwo);
                SetLoser(movieOne != this.Winner ? movieOne : movieTwo);
            }
        }

        private void Tiebreaker(MovieModel movieOne, MovieModel movieTwo)
        {
            if (string.CompareOrdinal(movieOne.Titulo, movieTwo.Titulo) < 0)
                SetWinner(movieOne);
            else
                SetWinner(movieTwo);

            SetLoser(movieOne != this.Winner ? movieOne : movieTwo);
        }

        private void SetWinner(MovieModel winner)
           => this.Winner = winner;
           
        private void SetLoser(MovieModel loser)
           => this.Loser = loser;

    }
}