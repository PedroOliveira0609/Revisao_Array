using System;

namespace ArrayRevisao
{
    class Program
    {
        static void Main(string[] args)
        {        
            string nime = string.Empty;

            string[] anime = new string[10];
            anime[0] = "One piece";
            anime[1] = "Bleach";
            anime[2] = "High school dxd";
            anime[3] = "Attack on Titan";
            anime[4] = "Hunter × Hunter";
            anime[5] = "Castlevania";
            anime[6] = "Pokémon";
            anime[7] = "Super onze";
            anime[8] = "Dinosauro rei";
            anime[9] = "Blue Exorcist";

            if (nime == "anime");
            {
                Console.WriteLine("A lista de anime é:");
                for (int i = 0; i < anime.Length; i++)
                {
                    Console.WriteLine($"Animes: {anime[i]}");

                }
            }
        }
    }   
}