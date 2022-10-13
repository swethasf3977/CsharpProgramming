using System;
namespace CheckAge;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Age");
        int value = int.Parse(Console.ReadLine());
        if (value >= 18)
        {
            System.Console.WriteLine("Eligible");
        }
        else
        {
            System.Console.WriteLine("Not Eligible");
        }

    }
}