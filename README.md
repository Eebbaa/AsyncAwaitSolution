# AsyncAwaitSolution

A simple C# console application demonstrating synchronous simulation of preparing breakfast. This project is intended to show how tasks can be modeled with Task.Delay to simulate time-consuming operations, and it can serve as a foundation for learning asynchronous programming in C#.

Reference: Asynchronous Programming in C#

🍳 Description

The program simulates preparing a full breakfast:

Pour a cup of coffee

Fry two eggs

Fry three slices of bacon

Toast two slices of bread and add butter and jam

Pour a glass of orange juice

Serve everything and print total time taken

All steps are currently synchronous, meaning each step waits for the previous one to finish. This is achieved using Task.Delay().Wait() to simulate time-consuming operations like cooking or toasting.

⚡ Classes & Methods
Main Entities

Coffee

Eggs

Bacon

Toast

Juice

Main Methods

PourCoffee() → Simulates pouring coffee

FryEggs(int howMany) → Simulates frying eggs

FryBacon(int slices) → Simulates frying bacon

ToastBread(int slices) → Simulates toasting bread

ApplyButter(Toast toast) → Apply butter on toast

ApplyJam(Toast toast) → Apply jam on toast

PourOJ() → Pour orange juice

⏱ Simulation Details

Each operation is delayed to mimic real cooking time:

Frying eggs: 3 seconds warming + 3 seconds cooking

Frying bacon: 3 seconds per side

Toasting bread: 3 seconds

Total time is measured using Stopwatch.

📝 Usage

Clone the repository or copy the code into a C# console project.

Run the project:

dotnet run


Observe console output showing step-by-step preparation and total time.

📌 Notes

This version is synchronous.

It can be refactored using async/await to allow parallel cooking, reducing total preparation time.
