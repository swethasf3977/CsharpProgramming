using System;
namespace LeapYear;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Year");
        int year = int.Parse(Console.ReadLine());
        if (year % 4 == 0)
        {

            System.Console.WriteLine("Leap year");
        }
        else
        {
            System.Console.WriteLine("Not Leap Year");
        }
    }
}