// See https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/?redirectedfrom=MSDN for more information
/*
 * 
 * The instructions for making a breakfast might be provided as a list:

Pour a cup of coffee.
Heat a pan, then fry two eggs.
Fry three slices of bacon.
Toast two pieces of bread.
Spread butter and jam on the toast.
Pour a glass of orange juice.

 */
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
namespace AsyncAwaitDemo
{
    class Program
    {
        internal class Bacon { }
        internal class Eggs { }
        internal class Toast { }
        internal class Juice { }
        internal class Coffee { }

        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew(); // Start measuring time
            Coffee cup = PourCoffee();
            Console.WriteLine("Coffee is ready");

            Eggs eggs = FryEggs(2);
            Console.WriteLine("Eggs are ready");

            Bacon bacon = FryBacon(3);
            Console.WriteLine("Bacon is ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("Toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("Orange juice is ready");
            Console.WriteLine("Breakfast is ready! Enjoy your meal!");

            stopwatch.Stop(); // Stop measuring time
            Console.WriteLine($"Total time taken: {stopwatch.Elapsed.TotalSeconds:F2} seconds");

        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring a glass of orange juice...");
            return new Juice();
        }
        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring a cup of coffee...");
            return new Coffee();
        }
        private static void ApplyJam(Toast toast)=>
        
            Console.WriteLine("Putting jam on the toast...");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast...");
        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Toasting slice of bread...");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait(); // Simulate time taken to toast bread
            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait(); // Simulate time taken to cook first side of bacon
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon...");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait(); // Simulate time taken to fry bacon
            Console.WriteLine("Bacon is ready, Put bacon on plate!");
            return new Bacon();
        }

        private static Eggs FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");
            return new Eggs();
        }



    }
}
