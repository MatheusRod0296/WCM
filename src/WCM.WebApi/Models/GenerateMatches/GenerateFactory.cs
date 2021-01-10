using System;

namespace WCM.WebApi.Models
{
    public  class GenerateFactory
    {       

         public static IGenerateMatches CreateGenerator(int moviesNumber)
        {
            switch (moviesNumber)
            {
                case 8:
                    return new QuarterFinals();
                case 4:
                case 2:
                    return new Finals();              

                default:
                    throw new ArgumentException("Número de filmes fora do escopo.");
            }
        }
    }
}