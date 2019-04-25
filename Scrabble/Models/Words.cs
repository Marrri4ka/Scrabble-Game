using System;
using System.Collections.Generic;

namespace WordsList.Models
{
  public class List //class
  {
    private string  _userWord;

    public List (string userWord)
    {
      _userWord = userWord;
    }


    public int GetScore()
    {
      return 5;
    }
  }
}
