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

      //OUT PARAMETERS
      string scoreAsString = "85.6";
      string statement = "Hello World";
      
      double scoreAsDouble;
      bool outcome = Double.TryParse(scoreAsString, out scoreAsDouble);

      Console.WriteLine($"{outcome}: {scoreAsDouble}");

      Console.WriteLine(Whisper(statement, out bool b));

      Console.WriteLine(b);

      //NAMED ARGUMENTS
      VisitPlanets(numberOfPlanets: 2);
      VisitPlanets(numberOfPlanets: 2, name: "Jumba");
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
    
    //OUT PARAMETER
    static string Whisper(string a, out bool b) {
      b = true;
      return a.ToLower();
    }

    //NAMED ARGUMENTS
    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
  }
}
