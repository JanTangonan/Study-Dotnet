using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest.PrintForestFacts();
      Console.WriteLine(Forest.ForestsCreated);

      Forest A = new Forest("Oak", "Tropical");
      Forest B = new Forest("Dark Oak");
      Forest C = new Forest("random");

      Console.WriteLine(Forest.ForestsCreated);
      Console.WriteLine(A.Biome);
      Console.WriteLine(B.Biome);
      Console.WriteLine(C.Biome);
    }
  }
}
