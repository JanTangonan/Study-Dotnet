using System;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};  

      Console.Write("Please input secret message: ");
      string? message = Console.ReadLine();
      string symbols = @"[^\w]+";
      message = Regex.Replace(message,symbols, String.Empty);
      message = message.ToLower();
      char[] secretMessage = message.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

      for(int i = 0; i < secretMessage.Length; i++) {
        char secretLetter = secretMessage[i];
        int index = (Array.IndexOf(alphabet, secretLetter) + 3) % alphabet.Length;
        secretLetter = alphabet[index];
        encryptedMessage[i] = secretLetter;
      }
      string msgString = String.Join("", encryptedMessage); 
      Console.WriteLine(msgString);
    }
  }
}