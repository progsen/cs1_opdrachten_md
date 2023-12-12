using System;

namespace ClassOpdracht2
{
    internal class ShopGreeter
    {
        private string greeting;
        internal ShopGreeter()
        {
            greeting = "Welcome customer! Please buy many many items!";

        }
        internal void GreetCustomer()
        {
            Console.WriteLine(greeting);
        }


    }
}