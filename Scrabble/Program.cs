using System;
using System.Collections.Generic;
namespace WordsList.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine ("Please enter your word");
      string UserWord = Console.ReadLine();
      List newList = new List(UserWord);
      string result = newList.GetScore().ToString();
      Console.WriteLine ("Your result is" + " " + result);
    }
  }
}
