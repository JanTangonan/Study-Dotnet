using System;

namespace CaptureOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      string designer = "Anders Hejlsberg";

      // int indexOfSpace = designer.IndexOf(" ");
      // string secondName = designer.Substring(indexOfSpace);
      
      Console.WriteLine(designer);
      int indexOfSpace = designer.IndexOf(" ");
      int indexOfSecondName = indexOfSpace + 1;

      string secondName = designer.Substring(indexOfSecondName);

      Console.WriteLine(secondName);

      Console.WriteLine(secondName);

      string msg = "Yabba dabba doo!";

      Math.Min(3,5);

      Console.WriteLine(msg);

      Console.WriteLine(msg.Substring(0,1));

      VisitPlanets(3);

      Console.WriteLine(DecoratePlanet("Jupiter"));

      IntroduceFriends("jumbs", "jumba");
      IntroduceFriends("jumbs", "jumba", "jumbe");
      IntroduceFriends();
    }

    static void VisitPlanets(int numberOfPlanets) {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }

    static string DecoratePlanet(string name) {
        return $"Welcome to {name}!";
    }

    //METHOD OVERLOADING
    static void IntroduceFriends(string a, string b) {
      Console.WriteLine($"These are my friends, {a} and {b}!");
    }

    static void IntroduceFriends(string a, string b, string c) {
      Console.WriteLine($"These are my friends, {a}, {b}, and {c}!");
    }

    static void IntroduceFriends() {
      Console.WriteLine("There is no one who needs to be introduced.");
    }
  }
}
