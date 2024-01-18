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
    [TestMethod]
    public void GetDayOfWeek_ReturnsMondayIfDayWasMonday_String()
    {
      DateTime dt = new DateTime(2024, 1, 15);
      string result = DayFinder.GetDayOfWeek(dt);
      Assert.AreEqual(result, "Monday");
    }
  }
}