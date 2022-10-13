using System;
namespace EvenOdd;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter value");
        int value = int.Parse(Console.ReadLine());
        if (value%2 == 0)
        {
            System.Console.WriteLine("Even number");
        }
        else
        {
            System.Console.WriteLine("Odd Number");
        }
    }
}