using System;
using System.Collections.Generic;

namespace WordsList.Models
{
  public class List //class
  {
    private string  _userWord; // property

    public List (string userWord)//constructor
    {
      _userWord = userWord;
    }


    public int GetScore()
    {
      int result = 0;
      string myString = "AEIOULNRST";
      char[] newArray = _userWord.ToCharArray();
      for (int i =0; i< newArray.Length; i++)
      {
        if(myString.Contains(newArray[i]))
        {
          result = result + 1;
        }
      }

      return result;

  }
}
}
