AsyncAwaitDemo

A C# console application demonstrating preparing breakfast synchronously.
The program simulates cooking tasks with delays using Task.Delay and prints each step along with the total preparation time.

Reference: [Asynchronous Programming in C#] (https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/?redirectedfrom=MSDN)

🥞 Features

    Pour a cup of coffee
    
    Fry eggs
    
    Fry bacon
    
    Toast bread and add butter & jam
    
    Pour orange juice
    
    Measure and display total time

🧩 Classes
      Class	Description
      Coffee	Represents a cup of coffee
      Eggs	Represents cooked eggs
      Bacon	Represents cooked bacon
      Toast	Represents toasted bread
      Juice	Represents a glass of juice

      
🔹 Methods
      Method	Purpose
      PourCoffee()	Simulates pouring coffee
      FryEggs(int howMany)	Simulates frying eggs
      FryBacon(int slices)	Simulates frying bacon
      ToastBread(int slices)	Simulates toasting bread
      ApplyButter(Toast toast)	Adds butter to toast
      ApplyJam(Toast toast)	Adds jam to toast
      PourOJ()	Simulates pouring orange juice

      
⏱ How It Works

      Each task uses Task.Delay().Wait() to simulate real cooking time:

      Frying eggs: 3s warming + 3s cooking

      Frying bacon: 3s per side

      Toasting bread: 3s

      Tasks are executed synchronously, one after another.

      Stopwatch measures total time taken for all steps.

💻 Usage

Clone the repository or copy the code into a C# console project.

    Build and run:

    dotnet run


    Observe console output showing each step and the total preparation time.

⚠️ Notes

    Currently, all tasks are synchronous.

    Can be refactored using async/await to allow parallel cooking, reducing total time.
