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

        static async Task Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew(); // Start measuring time
            
            //1. pour coffe
            Coffee cup = PourCoffee();
            Console.WriteLine("Coffee is ready");

         
            //2. Fry Egg, 3. Fry Bacon, 
            //Start tasks in parallel (but don't await yet)
            Task<Eggs> eggsTask = FryEggsAsync(2);
            Task<Bacon> baconTask = FryBaconAsync(3); // Start frying bacon without awaiting yet
            
            //Task<Toast> toastTask = ToastBreadAsync(2); // Start toasting bread without awaiting yet
            
            //4. Toast Bread, Jam and apply butter 
            Task<Toast> toastTask = MakeToastWithButterAndJamAsync(2);
            // Await the tasks to get the results (this will be after all have run concurrently)
            //7. Eggs are burnt
            Eggs eggs = await eggsTask;
            Console.WriteLine("Eggs are ready");

            //8. Bacon are ready
            Bacon bacon = await baconTask;
            Console.WriteLine("Bacon is ready");

            Toast toast = await toastTask;
            
            //ApplyButter(toast);
            //ApplyJam(toast);
            Console.WriteLine("Toast is ready");

            //6. Pour Juice
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
        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Toasting slice of bread...");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(3000); // Simulate time taken to toast bread
            return new Toast();
        }
        private static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000); // Simulate time taken to cook first side of bacon
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon...");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000); // Simulate time taken to fry bacon
            Console.WriteLine("Bacon is ready, Put bacon on plate!");
            
            return new Bacon();
        }

        private static async Task<Eggs> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");
     
            return new Eggs();
        }



    }
}
