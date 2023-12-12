using System;

namespace VariableOpdracht3
{
    internal class Program
    {
        //ga naar de file TwitchStream.cs in je solution explorer in visual studio
        static void Main(string[] args)
        {

            TwitchStream twitchStream = new TwitchStream("randomizer");
            twitchStream.SetTag("speedrun");
            Console.WriteLine("c# stream has the tag:");
            Console.WriteLine(twitchStream.GetTag());
        }
    }
}