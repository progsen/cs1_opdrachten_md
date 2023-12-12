using System;

namespace ClassOpdracht1
{
     ???
    //Schrijf met commentaar(//dit is commentaar) in deze file de naam bij elk onderdeel 
    internal class ClassStructureExercise
    {
        private readonly string accountName;

        internal ClassStructureExercise(string accountName)
        {
            this.accountName = accountName;
        }

        internal void ShowGreetingInConsole()
        {
            string greeting = "hello";
            Console.WriteLine(greeting + " " + accountName);
        }

        internal void Show1To10()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }

        internal double DistBetweenPoints(int x1, int y1, int x2, int y2)
        {

            int dx = x2 - x1;
            int dy = y2 - y1;

            double lengthSquared = (dx * dx) + (dy * dy);

            double length = Math.Sqrt(lengthSquared);
            return length;

        }
        internal int MultiplyToPower2(int value)
        {
            int result = value * value;
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }
    }
}