using System;

namespace Review
{
  public class MyClass
{
    public double compoundInterest(double p, double r, double n, double t) 
    {
      double a = p * Math.Pow((1 + (r/n)), n*t);
      return a;
    }

    public double dogYears(double age) 
    {
        double dogAge = age * 7;
        return dogAge;
    }
}
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      DATA TYPES: int, double
      ARITHMETIC OPERATORS: +, -, *, /
      INCREMENT/DECREMENT: ++, --
      MODULO: % 
      BUILT-IN METHODS: Abs, Pow, Sqrt, Floor, Ceiling, Min, Max

      Good luck! */

      MyClass MyObject = new MyClass();
      Console.WriteLine(MyObject.compoundInterest(1200, 5, 10, 4));
      Console.WriteLine(MyObject.dogYears(10));
    }
  }
}
