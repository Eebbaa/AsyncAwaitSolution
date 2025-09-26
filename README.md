AsyncAwaitDemo

A C# console application demonstrating preparing a breakfast synchronously. The program simulates time-consuming cooking tasks using Task.Delay and prints the steps and total preparation time.

Reference: Asynchronous Programming in C#

🥞 Features

      Pour a cup of coffee

      Fry eggs
      
      Fry bacon
      
      Toast bread and add butter & jam
      
      Pour orange juice

Measure and display total time taken

🧩 Classes
Class	Description
  Coffee	Represents a cup of coffee
  Eggs	Represents cooked eggs
  Bacon	Represents cooked bacon
  Toast	Represents toasted bread
  Juice	Represents a glass of juice
🔹 Methods
Method	                  Purpose
PourCoffee()	           Simulates pouring coffee
FryEggs(int howMany)	   Simulates frying eggs
FryBacon(int slices)	   Simulates frying bacon
ToastBread(int slices)	  Simulates toasting bread
ApplyButter(Toast toast)	Adds butter to toast
ApplyJam(Toast toast)	    Adds jam to toast
PourOJ()	                Simulates pouring orange juice
⏱ How It Works

Each cooking task uses Task.Delay().Wait() to simulate real time:

    Frying eggs: 3s warming + 3s cooking

    Frying bacon: 3s per side

    Toasting bread: 3s

    Stopwatch measures total time for all steps.

Usage

  Clone the repository or copy the code into a C# console project.

  Run the project:

    dotnet run


Observe the console output showing step-by-step preparation and total time.


Notes

  Currently, all tasks are synchronous and run sequentially.

  This project can be extended to async/await for parallel cooking, reducing total preparation time.
