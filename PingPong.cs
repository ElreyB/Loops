using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("What is you number?");
    string stringNumber = Console.ReadLine();
    int yourNumber = int.Parse(stringNumber);

    for (int number = 0; number <= yourNumber; number ++)
    {
      if (number == 0)
      {
        Console.WriteLine(number);
      }
      else if ((number % 5 == 0) && (number % 3 == 0))
      {
        Console.WriteLine("ping-pong");
      }
      else if (number % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if (number % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else
      {
        Console.WriteLine(number);
      }
    }
  }
}
