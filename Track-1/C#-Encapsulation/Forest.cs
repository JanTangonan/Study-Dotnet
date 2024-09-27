using System;

namespace AccessModifiers
{
  class Forest
  {
    // public string name;
    // private int trees;
    // private int age;
    // public string biome;

    // public Forest(string name, string biome) 
    // {
    //   this.name = name;
    //   this.biome = biome;
    //   age = 1;
    // }

    // public void Grow() 
    // {
    //   this.trees += 20;
    //   this.age++;
    // }

    // public void AnnounceForest()
    // {
    //   Console.WriteLine($"The {name} {biome} Forest is {age} years old and has {trees} trees");
    // }


    //-------------------------------------------------------------------------------------------------------------------------------------------------
    private string name;
    public int trees;
    public int age;
    private string biome;
    
    public string Name {
      get { return name; }
      set { name = value; }
    }

    public string Biome {
      get { return biome; }
      set { 
        string[] validBiomes = {"Tropical", "Temperate", "Boreal"};
        if (Array.IndexOf(validBiomes, value) >= 0) {
          biome = value;
        }
        // if (value == "Tropical" || value == "Temperature" || value == "Boreal") {
        //   biome = value; 
        // } 
        else {
          biome = "Unknown";
        }
      }
    }
  }

}