using System;
using System.Collections.Generic;

 class Program
{
 static void Main()
  {
    Console.WriteLine("Enter a Number: ");
    string input = Console.ReadLine();
    int num = int.Parse(input);
    // List<Program> PingPongs = new List<Program>();

    for (int i = 0; i <= num; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("PingPong");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}
