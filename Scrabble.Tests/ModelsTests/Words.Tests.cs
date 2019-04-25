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
    List newList = new List("A");
    // Act
    int result = newList.GetScore();
    // Assert
    Assert.AreEqual(result, 1);
  }
}
}
