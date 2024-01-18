using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;
using System;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class DayFinderTests
  {
    [TestMethod]
    public void GetDayOfWeek_ReturnsAString_String()
    {
      DateTime dt = new DateTime(2003, 5, 1);
      string result = DayFinder.GetDayOfWeek(dt);
      Assert.IsInstanceOfType(result, typeof(string));
    }
  }
}