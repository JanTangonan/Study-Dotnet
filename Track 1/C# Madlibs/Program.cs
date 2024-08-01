using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is called MadLibs
      Author: Jumba
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Program begin");

      // Give the Mad Lib a title:
      string title = "Solo Leveling";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      Console.Write("What is your favourite color : ");
      string adj1 = Console.ReadLine();
      Console.Write("What do y  ou feel : ");
      string adj2 = Console.ReadLine();
      Console.Write("What texture do you like : ");
      string adj3 = Console.ReadLine();

      Console.Write("What do you like to do: ");
      string verb = Console.ReadLine();

      Console.Write("Please choose between girl/boy : ");
      string noun1 = Console.ReadLine();
      Console.Write("Please choose between place : ");
      string noun2 = Console.ReadLine();

      Console.Write("Input your favourite animal : ");
      string animal = Console.ReadLine();
      Console.Write("Input your favourite food : ");
      string food = Console.ReadLine();
      Console.Write("Input your favourite fruit : ");
      string fruit = Console.ReadLine();
      Console.Write("Input your favourite superhero : ");
      string superhero = Console.ReadLine();
      Console.Write("Input your favourite country : ");
      string country = Console.ReadLine();
      Console.Write("Input your favourite dessert : ");
      string dessert = Console.ReadLine();
      Console.Write("Input your year : ");
      string year = Console.ReadLine();
      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
