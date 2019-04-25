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
    List newList = new List("DaO");
    // Act
    int result = newList.GetScore();
    // Assert
    Assert.AreEqual(result, 4);
  }

  [TestMethod]
  public void GetScore3_Test()
  {
    //Arrange
    List newList = new List("BaG");
    // Act
    int result = newList.GetScore();
    // Assert
    Assert.AreEqual(result, 6);
  }

  [TestMethod]
  public void GetScore4_Test()
  {
    //Arrange
    List newList = new List("HADb");
    // Act
    int result = newList.GetScore();
    // Assert
    Assert.AreEqual(result, 10);
  }

  [TestMethod]
  public void GetScore5_Test()
  {
    //Arrange
    List newList = new List("KdBa");
    // Act
    int result = newList.GetScore();
    // Assert
    Assert.AreEqual(result, 11);
  }

  [TestMethod]
  public void GetScore8_Test()
  {
    //Arrange
    List newList = new List("XDA");
    // Act
    int result = newList.GetScore();
    // Assert
    Assert.AreEqual(result,11);
  }

  [TestMethod]
  public void GetScore10_Test()
  {
    //Arrange
    List newList = new List("qad");
    // Act
    int result = newList.GetScore();
    // Assert
    Assert.AreEqual(result,13);
  }
}
}
