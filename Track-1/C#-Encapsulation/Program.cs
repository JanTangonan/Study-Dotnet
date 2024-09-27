using System;

namespace AccessModifiers
{
  class Program
  {
    static void Main(string[] args)
    {
      // Forest f = new Forest("Congo", "Tropical");
      // f.AnnounceForest();
      // f.Grow();
      // f.AnnounceForest();

      Forest f = new Forest();
      f.Name = "Congo";
      f.trees = 0;
      f.age = 0;
      f.Biome = "Tropical";
      
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
    }
  }
}
