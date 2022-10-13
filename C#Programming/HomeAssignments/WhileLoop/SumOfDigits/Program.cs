using System;
namespace SumOfDigits;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        int rem;
        while (number > 0)
        {
            rem = number %10;
            count += rem;
            number = number /10;

        }
        System.Console.WriteLine(count);
    }
}