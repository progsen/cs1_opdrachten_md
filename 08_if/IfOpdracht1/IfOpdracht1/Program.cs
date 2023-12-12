using System;

namespace IfOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int nummerA = 1;
            int nummerB = 2;
            int nummerC = 1;


            

            if(false)//vervang false met een test of nummerA gelijk is aan nummerB
            {
                Console.WriteLine("nummerA is gelijk aan nummerB");
            }
            else
            {
                Console.WriteLine("nummerA is niet gelijk aan nummerB");//deze moet je zien
            }



            if (false)//vervang false met een test of nummerA gelijk is aan nummerC
            {
                Console.WriteLine("nummerA is gelijk aan nummerC");//deze moet je zien
            }
            else
            {
                Console.WriteLine("nummerA is niet gelijk aan nummerC");
            }



            if (false)//vervang false met een test of nummerA + nummerC gelijk is aan nummerB
            {
                Console.WriteLine("nummerA+ nummerC is gelijk aan nummerB");//deze moet je zien
            }


            if (false)//vervang false met een test of nummerA NIET (!) gelijk is aan nummerB
            {
                Console.WriteLine("nummerA is niet gelijk aan nummerB");//deze moet je zien
            }




        }
    }
}