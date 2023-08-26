using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the month number");
        int monthNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the year:");
        int year = Convert.ToInt32(Console.ReadLine());

        int daysInMonth = GetDaysInMonth(monthNumber, year);

        if (daysInMonth == -1)
        {
            Console.WriteLine("Invalid month number.");
        }
        else
        {
            Console.WriteLine($"Number of days in month {monthNumber}: {daysInMonth}");
        }
    }

    static int GetDaysInMonth(int monthNumber, int year)
    {
        switch (monthNumber)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                return 31;
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            case 2:
                return IsLeapYear(year) ? 29 : 28;
            default:
                return -1; // Invalid month number
        }
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 );
    }
}
