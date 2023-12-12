using System;

namespace ForOpdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            float[] vectors = new float[] { 6, 7, 8, 1, 4, 0 };//2 vectoren (6,7,8) en (1,4,0) achter elkaar net als bij shaders

            //nu willen we per vector door de array lopen dat moet dus met stappen van 3
            for (int i = 0; i < vectors.Length; i++)//zorg ervoor dat we niet i + 1 doen maar +3
            {
                float x = vectors[??];//pak hier de waarde op index i (x)
                float y = vectors[??];//pak hier de waarde op index i + 1 (y)
                float z = vectors[??];//pak hier de waarde op index i + 2 (z)
                Console.WriteLine($"vector {x}, {y}, {z}");
            }

        }
    }
}