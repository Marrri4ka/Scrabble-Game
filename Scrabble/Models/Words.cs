using System;
using System.Collections.Generic;

namespace WordsList.Models
{
  public class List //class
  {
    private string  _userWord; // property

    public List (string userWord)//constructor
    {
      _userWord = userWord.ToUpper();
    
    }


    public int GetScore()
    {
      int result = 0;
      string myString = "AEIOULNRST";
      string mySecondString = "DG";
      string myThirdString = "BCMP";
      string myFourthString = "FHVWY";
      string myFifthString = "K";
      string mySixthString = "JX";
      string mySeventhString = "QZ";
      char[] newArray = _userWord.ToCharArray();
      for (int i =0; i< newArray.Length; i++)
      {
        if(myString.Contains(newArray[i].ToString()))
        {
          result = result + 1;
        }

        else if (mySecondString.Contains(newArray[i].ToString()))
        {
          result = result +2;
        }

        else if (myThirdString.Contains(newArray[i].ToString()))
        {
          result = result + 3;
        }

        else if (myFourthString.Contains(newArray[i].ToString()))
        {
          result = result + 4;
        }

        else if (myFifthString.Contains(newArray[i].ToString()))
        {
          result = result + 5;
        }
        else if (mySixthString.Contains(newArray[i].ToString()))
        {
          result = result + 8;
        }
        else if (mySeventhString.Contains(newArray[i].ToString()))
        {
          result = result + 10;
        }
      }

      return result;

  }
}
}
