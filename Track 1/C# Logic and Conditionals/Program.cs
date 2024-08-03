using System;

namespace ComparisonOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      double timeToDinner = 4;
      double distance = 95;
      double rate = 30;

      double tripDuration = distance/rate;
      bool answer = tripDuration <= timeToDinner;
      
      Console.WriteLine(answer);

      bool beach = true;
      bool hiking = false;
      bool city = true;

      bool yourNeeds = beach && city;
      bool friendNeeds = beach || hiking;

      bool tripDecision = yourNeeds && friendNeeds;
      Console.WriteLine(tripDecision);


      int people = 11;
      string weather = "not good";
        if (people <= 10 && weather == "nice") {
          Console.WriteLine("SaladMart");
        } else {
          Console.WriteLine("Soup N Sandwich");
        }
        
      int guests = 0;
      if (guests >= 4) {
        Console.WriteLine("Catan");
      } else if (guests >= 1) {
        Console.WriteLine("Innovation");
      } else {
        Console.WriteLine("Solitaire");
      }
    }
  }
}
