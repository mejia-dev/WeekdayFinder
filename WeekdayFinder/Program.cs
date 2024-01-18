using System;
using WeekdayFinder.Models;

class Program
{
  static void Main()
  {
    // C# Program code goes here.
    GetYear();
    



    // DateTime inputtedDate = new DateTime(year, month, day);
    // inputtedDate
  }

  static void GetYear()
  {
    try
    {
      Console.WriteLine("Input the numerical year in YYYY format:");
      string year = Console.ReadLine();
      if (year.ToString().Length != 4)
      {
        Console.WriteLine("Check format and try again.");
        GetYear();
      } else {
        int yearInt = int.Parse(year);
        Console.WriteLine("");
        GetMonth(yearInt);
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine("{0} Please try again.", ex.Message);
      GetYear();
    }
  }
  static void GetMonth(int year)
  {
    try
    {
      Console.WriteLine("Input the numerical month in MM format:");
      string month = Console.ReadLine();
      int monthInt = int.Parse(month);
      if (month.Length != 2)
      {
        Console.WriteLine("Check format and try again.");
        GetMonth(year);
      } 
      else if (monthInt < 1 || monthInt > 12)
      {
        Console.WriteLine("Month can't be less than 1 or greater than 12.");
        GetMonth(year);
      }
      else
      {
        Console.WriteLine("");
        GetDay(year, monthInt);
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine("{0} Please try again.", ex.Message);
      GetMonth(year);
    }
  }

  static void GetDay(int year, int month)
  {
    try
    {
      Console.WriteLine("Input the numerical day in DD format:");
      string day = Console.ReadLine();
      int dayInt = int.Parse(day);
      if (day.ToString().Length != 2)
      {
        Console.WriteLine("Check format and try again.");
        GetDay(year, month);
      }
      // if month is odd, get 31 days
      else if ((month%2 != 0) && (dayInt < 1 || dayInt > 31))
      {
        Console.WriteLine("This month doesn't have that many days. Please try again.");
        GetDay(year, month);
      }

      // if month is even AND NOT 2, get 30 days
      else if ((month%2 == 0) && (month != 2) && (dayInt < 1 || dayInt > 30))
      {
        Console.WriteLine("This month doesn't have that many days. Please try again.");
        GetDay(year, month);
      }

      // if month is even AND 2, AND if year is divisible by 4, get 29 days
      else if ((month%2 == 0) && (month == 2) && (year%4 == 0) && (dayInt < 1 || dayInt > 29))
      {
        Console.WriteLine("This month doesn't have that many days. Please try again.");
        GetDay(year, month);
      }

      // if month is even AND 2, AND if year is not divisible by 4, get 28 days
      else if ((month%2 == 0) && (month == 2) && (year%4 != 0) && (dayInt < 1 || dayInt > 28))
      {
        Console.WriteLine("This month doesn't have that many days. Please try again.");
        GetDay(year, month);
      }
      
      else {
        SendToDayFinder(year, month, dayInt);
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine("{0} Please try again.", ex.Message);
      GetDay(year, month);
    }
  }

  static void SendToDayFinder(int year, int month, int day)
  {
    DateTime dt = new DateTime(year, month, day);
    string result = DayFinder.GetDayOfWeek(dt);
    ShowResult(result);
  }

  static void ShowResult(string result)
  {
    Console.WriteLine("The day of the week from your input was {0}.", result);
  }

}