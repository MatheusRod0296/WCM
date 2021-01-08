namespace WCM.WebApi.Models
{
    public class ResultTournament
    {
        public ResultTournament(MovieModel firstPlace, MovieModel secondPlace)
        {
            FirstPlace = firstPlace;
            SecondPlace = secondPlace;
        }

        public MovieModel FirstPlace { get; private set; }
        public MovieModel SecondPlace { get; private set; }
    }
}