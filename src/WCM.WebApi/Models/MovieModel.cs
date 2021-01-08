namespace WCM.WebApi.Models
{
    public class MovieModel
    {
        public MovieModel(string id, string titulo, int ano, double nota)
        {
            Id = id;
            Titulo = titulo;
            Ano = ano;
            Nota = nota;
        }

        public string Id { get;private set; } 
        public string Titulo { get;private set; } 
        public int Ano { get;private set; } 
        public double Nota { get;private set; } 
    }
}