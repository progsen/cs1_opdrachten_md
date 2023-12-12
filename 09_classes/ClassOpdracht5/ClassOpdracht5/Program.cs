using System;
using System.Threading.Tasks;
using System.Threading;

namespace ClassOpdracht5
{
    //Maak de opdrachten in Game & Tile
    //klaar? commit, en dan kijk eens wat je hier mee zou kunnen maken ^^
    partial class Program
    {
        private Game game;

        static void Main()
        {
            Program p = new();
            p.MainLoop();
        }

        internal Program()
        {
            Console.CursorVisible = false;
            game = new Game();
        }

        private void MainLoop()
        {
            while (true)
            {
                game.RenderWithConsole();
                ReadInput();

                Thread.Sleep(100);
            }
        }

        private void ReadInput()
        {

            ConsoleKeyInfo key = Console.ReadKey(false);

            if (key.Key == ConsoleKey.UpArrow)
            {
                game.MovePlayer(0, -1);
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                game.MovePlayer(0, 1);
            }

            if (key.Key == ConsoleKey.LeftArrow)
            {
                game.MovePlayer(-1, 0);
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                game.MovePlayer(1, 0);
            }
        }
    }
}