using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    { 
      Console.WriteLine($"Total Cost is {Math.Round(CalculateTotalCost(Rectangle(2500, 1500),Circle(375),Triangle(750, 500)),2)} Mexican Pesos");
    }

    static double Rectangle(double L, double W) {
      double area = L * W;
      return area;
    }

    static double Circle(double R) {
      double area = (R * R) * Math.PI;
      return area; 
    }

    static double Triangle(double B, double H) {
      double area = 0.5 * B * H;
      return area;
    }

    static double CalculateTotalCost(double A, double B, double C) {
      double totalCost = (A + B + C) * 180;
      return totalCost;
    }
  }
}
