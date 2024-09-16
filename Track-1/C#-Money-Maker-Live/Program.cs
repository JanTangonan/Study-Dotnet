using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter amount");
      double amount = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine(amount + " cents is equal to...");

      double gold = 10;
      double silver = 5;
      double bronze = 1;
      double goldCoins = Math.Floor(amount/gold);
      double remainder = amount%gold;
      double silverCoins= Math.Floor(remainder/silver);
      remainder = remainder%silver;
      double bronzeCoins = remainder/bronze;

      Console.WriteLine("Gold Coins: " + goldCoins);
      Console.WriteLine("Silver Coins: " + silverCoins);
      Console.WriteLine("Bronze Coins: " + bronzeCoins);
    }
  }
}
