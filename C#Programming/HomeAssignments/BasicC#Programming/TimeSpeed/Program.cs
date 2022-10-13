using System;
namespace TimeSpeed;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter speed ");
        int value1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter seconds ");
        int value2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Distance"+(value1*value2 * 5/18));
    }
}