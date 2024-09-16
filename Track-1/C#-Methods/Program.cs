using System;

namespace CaptureOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      string designer = "Anders Hejlsberg";

      int indexOfSpace = designer.IndexOf(" ");
      string secondName = designer.Substring(indexOfSpace);

      Console.WriteLine(secondName);

      string msg = "Yabba dabba doo!";

      Math.Min(3,5);

      Console.WriteLine(msg);

      Console.WriteLine(msg.Substring(0,1));

      
    }
  }
}
