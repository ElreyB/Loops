using System;

class ExcitedAbout
{
  static void Main()
  {
    string[] excitedAbout = {"Programming", "dance", "art", "school"};

    Console.WriteLine("Things I am " + "excited".ToUpper() + " about.");

    foreach (string activity in excitedAbout)
    {
      Console.WriteLine(activity.ToUpper() + "!");
    }
  }
}
