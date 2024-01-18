using System;

namespace WeekdayFinder.Models
{
  public class DayFinder
  {
    public static string GetDayOfWeek(DateTime dateTime)
    {
      return dateTime.DayOfWeek.ToString();
    }
  }
}