using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordsList.Models;

namespace Words.Test
{
[TestClass]
public class ListTest
{
  [TestMethod]
  public void GetScore_Test()
  {
    //Arrange
    List newList = new List("AEI");
    // Act
    int result = newList.GetScore();
    // Assert
    Assert.AreEqual(result, 3);
  }


  [TestMethod]
  public void GetScore2_Test()
  {
    //Arrange
    List newList = new List("DA");
    // Act
    int result = newList.GetScore();
    // Assert
    Assert.AreEqual(result, 3);
  }

  [TestMethod]
  public void GetUpperCase_Test()
  {
    //Arrange
    List newList = new List("DaOpdR");
    // Act
    int result = newList.GetScore();
    // Assert
    Assert.AreEqual(result, 5);
  }
}
}
