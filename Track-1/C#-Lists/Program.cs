using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };
      
      citiesList.Add("New York City");
      
    //   citiesList.Remove("Delhi");
      
      citiesList.AddRange(new string[] {"Cairo", "Johannesburg"});
      
      bool hasNewDelhi = citiesList.Contains("Delhi");
      
      foreach (string city in citiesList)
      {
        Console.WriteLine(city);
      }

      Console.WriteLine(hasNewDelhi);
      
      //LIST INITIALIZATION - USING ADD
    //   List<double> marathons = new List<double>();
    //   marathons.Add(144.07);
    //   marathons.Add(143.12);
    //   marathons.Add(146.73);
    //   marathons.Add(146.33);

      //LIST INITIALIZATION
      List<double> marathons = new List<double> {
        144.07, 143.12, 146.73, 146.33
      };
      
      // Do not delete the code below
      double time = marathons[1];
      
      Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");

      //CONTAINS and COUNT
      Console.WriteLine(marathons.Count);
      marathons.Add(143.23);
      Console.WriteLine(marathons.Contains(143.23));
      Console.WriteLine(marathons.Count);

      //REMOVE
      Console.WriteLine(marathons[1]);
      bool removed = marathons.Remove(143.12);
      Console.WriteLine(removed);
      Console.WriteLine(marathons[1]);

      //CLEAR
      marathons.Clear();
      Console.WriteLine($"Count: {marathons.Count}");

      List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
      Random rand = new Random();
      
      Console.WriteLine("In reverse chronological order, the gold medalists are...");
      

      //LOOPING THROUGH LISTS
      // First loop
      for (int i = 0; i < runners.Count; i++)
      {
        Console.WriteLine($"{i+1}: {runners[i]}");
      }
      
      Console.WriteLine("\nPrinting runner bibs...");
      
      // Second loop
      for (int i = 0; i < runners.Count; i++)
      {
        string name = runners[i].ToUpper();
        int id = rand.Next(100, 1000);
        Console.WriteLine($"{id} - {name}");
      }

      foreach (string runner in runners) {
        Console.WriteLine(runner);
      }


      //WORKING WITH RANGES
      List<double> topMarathons = marathons.GetRange(0, 3);

      foreach(double topMarathon in topMarathons) {
        Console.WriteLine(topMarathon);
      }

      List<string> places = new List<string> { "first", "second" };
      
      places.AddRange(new string[] { "fifth", "sixth" });
      // List is  "first", "second", "fifth", "sixth" ]
      places.InsertRange(2, new string[] { "third", "fourth"});
      // List is [ "first", "second", "third", "fourth", "fifth", "sixth" ]
      places.RemoveRange(4, 2);
      // List is [ "first", "second", "third", "fourth" ]
      List<string> newPlaces = places.GetRange(0, 3);
      // New list is [ "first", "second", "third" ]

      //CREATING LISTS WITH DIFFERENT TYPES
      List<bool> bools = new List<bool>(); 
      List<Random> randoms = new List<Random>(); 
      List<IServiceProvider> IServiceProviders = new List<IServiceProvider>();    
    }
  }
}
