using System;

namespace FunctionOpdracht5
{
    internal class Program
    { 
        string heroName;
        int heroStrength;
        int health;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }


        private void Run()
        {

			Console.WriteLine("choose your hero's name");
            heroName = GetHeroName(); //heroName zit op Program (this)

            Console.WriteLine($"your hero is called {heroName}");

            SetHeroStrength(9999);//super sterk natuurlijk

            //1) roep hier de SetHealth aan met een 1000;

            while(IsHeroDead())//4) maak deze function, deze geeft een true  terug als health <= 0, anders geeft deze false terug
            {
                //fight!

               	int dam = RollDamage();//5) maak deze function, je mag een random gebruiken of een vast getal
              
            	Console.WriteLine($"your hero takes {dam} damage");
				DoDamageToHero(dam);//6) maak deze function, deze haalt dam af van de health (op program)

            	Console.WriteLine($"your hero has {health} health");
            }

            Console.WriteLine("oefening compleet!");
        }

        //2) maak hier een function GetHeroName die met Console.ReadLine() een helden naam vraagt

        //3) maak hier een function SetHeroStrength met 1 argument  van type 'int'
        //in de body van de function zet de waarde van heroStrength (van program) het 

        //
        private void SetHealth(int health)
        {
            this.health = health;
        }
    }
}