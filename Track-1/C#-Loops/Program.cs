using System;

namespace WhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      int emails = 20;
      Console.WriteLine(emails);
      //WHILE LOOP
      
      while (emails != 0) {
        emails--;
        Console.WriteLine($"Remaining Emails: {emails}.");
      }
      Console.WriteLine("INBOX ZERO ACHIEVED!");

      string[] websites = { "twitter", "facebook", "gmail" };
      int c = 0;
      
      while (c < websites.Length)
      { 
        Console.WriteLine(websites[c]); 
        c++; 
      }

      //DO WHILE LOOP
      int counter = 0;
      
      do {
        Console.WriteLine("Alarm Ringing");
        counter++;
      } while (counter < 10);
      Console.WriteLine("Time for a five minute break.");
      
      //FOR LOOP
      for (int i = 1; i <= 16; i++){
        CreateTemplate(i);
      }

      //FOREACH
      string[] todo = {"respond to email", "make wireframe", "program feature", "fix bugs"};
      
      foreach (string list in todo)
      {
      Console.WriteLine($"[] {list}");
      }

      foreach (string sites in websites){
        Console.WriteLine(sites);
      }
    }
    static void CreateTemplate(int week)
    {
      Console.WriteLine($"Week {week}");
      Console.WriteLine("Announcements: \n \n \n ");
      Console.WriteLine("Report Backs: \n \n \n");
      Console.WriteLine("Discussion Items: \n \n \n");
    }
  }
}
