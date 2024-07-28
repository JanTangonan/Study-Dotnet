using System;

namespace PrideAndPrejudice
{
  class Program
  {
    static void Main(string[] args)
    {
      // First string variable
      string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want ofa wife.";
      // Second string variable
      string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

      // Print variable and newline
      Console.WriteLine(firstSentence);
      Console.WriteLine("\n");
      Console.WriteLine(firstSpeech);

      // Create password
      string password = "a92301j2add";

      // Get password length
      int passwordLength = password.Length;

      // Check if password uses symbol
      int passwordCheck = password.IndexOf("!");

      // Print results
      Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");
    }
  }
}
