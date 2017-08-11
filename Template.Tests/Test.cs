using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using ChangeName.Models;

namespace ChangeName.Tests
{
  [TestClass]
  public class ClassNameTest : IDisposable
  {
    [TestMethod]
    public void MethodToBeTested_BehaviorToBeTested_ExpectedResultOfTest()
    {
      //Arrange
      List<string> expected = new List<string> {"expectedOutput"};
      ClassName newVariable = new ClassName("input");

      //Act
      List<string> actual = newVariable.MethodName();

      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }

    public void Dispose()
    {
      Class.ClearAll();
    }
  }
}
