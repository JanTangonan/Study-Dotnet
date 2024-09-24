using System;
using OverloadingConstructors;

namespace DefiningClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo","Tropical");
      f.trees = 0;
      
      Console.WriteLine(f.name);
      Console.WriteLine(f.biome);
      Console.WriteLine(f.trees);
      Console.WriteLine(f.age);

      Forest a = new Forest("Rendlesham");
      Console.WriteLine(a.biome);
    }
  }
}
