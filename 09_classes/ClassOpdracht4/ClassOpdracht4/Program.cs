using System;

namespace ClassOpdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] startScreenLines = new string[] { "\t\tstart scherm!", "press enter :)" };
            GameScreen startScreen = new GameScreen(startScreenLines);

            string[] endScreenLines = new string[] { "","","The end?","\t\t\t\t kinda short..." };
            GameScreen endScreen = new GameScreen(endScreenLines);

            //deze werkt niet, ga naar gamerenderer en volg de opdrachten in commentaar
            GameRenderer renderer= new GameRenderer(startScreen);


            renderer.Render();

            string startInput = Console.ReadLine();

            renderer.SetScreen(endScreen);
            renderer.Render();
        }
    }
}