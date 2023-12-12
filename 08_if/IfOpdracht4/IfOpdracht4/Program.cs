using System;

namespace IfOpdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //open ook de EnemyCollider.cs file daar moet je de functions aanpassen

            Enemy walker = new Enemy();
            Enemy flyer = new Enemy() { flying = true };
            Enemy ghost = new Enemy() { incoporial = true };
            Enemy swimmer = new Enemy() { swimmer = true };
            Enemy subterranian = new Enemy() { subterranian = true };
            //we gaan de OR opertator (||) gebruiken

            EnemyCollider enemyCollider = new EnemyCollider();
            if (enemyCollider.CanPassWall(flyer))
            {
                Console.WriteLine("flew over the wall");
            }
             if (enemyCollider.CanPassWall(ghost))
            {
                Console.WriteLine("passed right through the wall");
            }
             if (enemyCollider.CanPassWall(swimmer))
            {
                Console.WriteLine("swam through the wall?"); //deze zie je niet
            }
             if (enemyCollider.CanPassWall(subterranian))
            {
                Console.WriteLine("Went underneath the wall");
            }
             if (enemyCollider.CanPassWater(walker))
            {
                Console.WriteLine("walked through the wall what???");//deze zie je niet
            }

            if (enemyCollider.CanPassWater(flyer))
            {
                Console.WriteLine("flew over the water");
            }
             if (enemyCollider.CanPassWater(ghost))
            {
                Console.WriteLine("flew over the water");
            }
             if (enemyCollider.CanPassWater(swimmer))
            {
                Console.WriteLine("swam through the water");
            }
             if (enemyCollider.CanPassWater(subterranian))
            {
                Console.WriteLine("Went underneath the water");
            }
             if (enemyCollider.CanPassWater(walker))
            {
                Console.WriteLine("walked on water what???");//deze zie je niet
            }
        }
    }
}