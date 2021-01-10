namespace WCM.WebApi.Models
{
    public class ResultChampionship
    {
        public ResultChampionship(MovieModel firstPlace, MovieModel secondPlace)
        {
            FirstPlace = firstPlace;
            SecondPlace = secondPlace;
        }

        public MovieModel FirstPlace { get; private set; }
        public MovieModel SecondPlace { get; private set; }
    }
}