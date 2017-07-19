using System;

class EvenOrOdd
{
  static void Main()
  {
    Console.WriteLine("Give me a whole number.");
    string stringNumber = Console.ReadLine();
    int number = int.Parse(stringNumber);

    for (int checkNumber = 1; checkNumber <= number; checkNumber ++)
    {
      if (checkNumber % 2 == 0)
      {
        Console.WriteLine("Even");
      }
      else
      {
        Console.WriteLine("Odd");
      }
    }
  }
}
