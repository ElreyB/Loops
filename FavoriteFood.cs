using System;

class FavoriteFood
{
  static void Main()
  {
    string[] favoriteFood =
    {"pizza",
     "dumplings",
     "ramen",
     "sushi",
     "cheese burger",
     "seattle dog",
     "hoagie",
     "chips",
     "brownie",
     "cake"
   };

   for (int index = 0; index < 5; index ++)
   {
     Console.WriteLine("I am eating " + favoriteFood[index]);
   }
  }
}
