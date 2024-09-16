using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
      string lowercase = "qwertyuiopasdfghjklzxcvbnm";
      string digits = "1234567890";
      string specialChars = "!@#$%^&*()-=_+|,./<>?[]{};:";

      int score = 0;

      Console.WriteLine("Please input Password");
      string password = Console.ReadLine();

      if (password.Length >= minLength) {
        score += 1;
      } 
      if (Tools.Contains(password, uppercase)){
        score += 1;
      } 
      if (Tools.Contains(password, lowercase)){
        score += 1;
      } 
      if (Tools.Contains(password, digits)){
        score += 1;
      } 
      if (Tools.Contains(password, specialChars)){
        score += 1;
      } 

      Console.WriteLine(score);

      switch(score) 
      {
        case 1:
        Console.WriteLine("Weak");
        break;
        case 2:
        Console.WriteLine("Medium");
        break;
        case 3:
        Console.WriteLine("Strong");
        break;
        case 4:
        Console.WriteLine("Extremely Strong");
        break;
        case 5:
        Console.WriteLine("Extremely Strong");
        break;

        default:
        Console.WriteLine("Pasword does not meet the standards");
        break;
      }
    }
  }
}
