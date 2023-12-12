using System;

namespace ArrayOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            int[] array; //maak hier een nieuwe array, met vulling gebruik  new int[] { hier je cijfers}; zorg dat je minimaal 6 cijfers hebt

            //kijk nu wat er gebeurt als je het programma runt
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}