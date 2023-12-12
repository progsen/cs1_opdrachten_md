using System;

namespace IfOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Enemy enemy = new Enemy() { hp = 10 };

            enemy.hp -= 5;
            Console.WriteLine("you hit enemy for 5 damage");
            if (false)//vervang false door een test of enemy.hp groter dan 0 is
            {
                Console.WriteLine("enemy is still alive!");
            }

            enemy.hp -= 20;
            Console.WriteLine("you hit enemy for 20 damage");

            if (false)//vervang false door een test of enemy.hp kleiner of gelijk aan 0 is
            {
                Console.WriteLine("enemy was defeated");
            }
        }
    }
}