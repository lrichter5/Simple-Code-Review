using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use the Salutation Class for a Walmart Greeter.
            Salutation oldGuy = new Salutation("Welcome to Walamrt!", "Thanks for shoppoing at walmart!");
            // Get the guy to talk...
            Console.WriteLine(oldGuy.Greet());
            Console.WriteLine(oldGuy.SayFareWell());
        }
    }
}
