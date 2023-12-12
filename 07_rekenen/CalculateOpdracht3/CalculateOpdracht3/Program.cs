using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            double totaalPrijs = 759.95;// tel hier alles bij elkaar op

            //oof wat duur, maar we hebben een kortings bon! 20% korting

            //eerst even uitrekenen wat we dan eigenlijk betalen , 100% - 20%

            double prijsProcentBetalen = 0;// maak hier de som  100% - 20% (% mag je weglaten)

            //nu de echte prijs dan moeten we eerst de prijs door 100.0 delen en dan keer prijsProcentBetalen

            double doorHondered = 0;//maak hier de totalPrijs GEDEELD DOOR 100.0 som

            double teBetalen = 0;//nu doorHondered KEER prijsProcentBetalen

            //er moet nu 607.96 staan
            Console.WriteLine($"te betalen {teBetalen}");
        }
    }
}