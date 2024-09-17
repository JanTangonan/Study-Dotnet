using System;

namespace BuildingArrays
{
  class Program
  {
    static void Main(string[] args)
    {
        string[] summerStrut;
        summerStrut = new string[] {
          "Juice",
          "Missing U",
          "Raspberry Beret",
          "New York Groove",
          "Make Me Feel",
          "Rebel Rebel",
          "Despacito",
          "Los Angeles"
        };

        int[] ratings = { 1, 2, 3, 4, 5, 5, 5, 5};

        if (summerStrut.Length == 8) {
          Console.WriteLine("summerStrut Playlist is ready to go!");
        } else if (summerStrut.Length > 8) {
          Console.WriteLine("Too many songs!");
        } else {
          Console.WriteLine("Add some songs!"); 
        }

        Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars.");

        summerStrut[7] = "Krystal";
        ratings[7] = 5;

        
        int x = Array.IndexOf(ratings, 3) + 1;
        Console.WriteLine($"Song number {x} is rated three stars");

        Array.Reverse(summerStrut);
        Console.WriteLine(summerStrut[0]);
        Console.WriteLine(summerStrut[7]);      

        Array.Sort(summerStrut);
        Console.WriteLine(summerStrut[0]);
        Console.WriteLine(summerStrut[7]);     

         
    }
  }
}
