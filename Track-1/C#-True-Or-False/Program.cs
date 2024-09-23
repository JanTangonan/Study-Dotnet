using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      // Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      // string entry = Console.ReadLine();
      // Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {
        "Sharks are mammals.",
        "Sea otters have a favorite rock they use to break open food.",
        "The blue whale is the biggest animal to have ever lived.",
        "The hummingbird egg is the world's smallest bird egg.",
        "Pigs roll in the mud because they don't like being clean."
        };
      bool[] answers = {
        false, true, true, true, false
      };

      bool[] responses = new bool[5];

      if (questions.Length != answers.Length) {
        Console.WriteLine("WARNING!");      
      }

      int askingIndex = 0;

      foreach (string question in questions) {
        string input;
        bool isBool = true;
        bool inputBool = false;

        Console.WriteLine(question);
        Console.WriteLine("True or false?");
        input = Console.ReadLine().ToLower();

        if (input == "true" || input == "false"){
            isBool = true;
            if (input == "true") {
              inputBool = true;
            } else {
              inputBool = false;
            }
          } else {
            isBool = false;
          }

        while (!isBool) {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine().ToLower();

          if (input == "true" || input == "false"){
            isBool = true;
            if (input == "true") {
              inputBool = true;
            } else {
              inputBool = false;
            }
          } else {
            isBool = false;
          }
        }
        responses[askingIndex] = inputBool;
        askingIndex++;
      }
      
      foreach (bool response in responses) {
        Console.WriteLine(response);
      }
      
      int scoringIndex = 0;
      int score = 0;

      foreach (bool answer in answers) {
        Console.WriteLine($"{scoringIndex + 1}. Input: {responses[scoringIndex]} | Answer: {answer}");
        if (responses[scoringIndex] == answer) {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} out of 5 correct!");
    }
  }
}
