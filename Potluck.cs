using System;
using System.Collections.Generic;

class Potluck
{
  public static Dictionary<string, string> potluckGuestList = new Dictionary<string, string>(){ {"Lounh", "Lemon Sqaures"}, {"Bob", "Bread Pudding"}, {"Oscar", "Oven Baked Mac & Cheese"}};

  static void Main()
  {
    Console.WriteLine("POTLUCK GUEST LIST");

    foreach(var list in potluckGuestList)
    {
      Console.WriteLine("{0} will bring {1}.", list.Key, list.Value);
    }
  }
}
