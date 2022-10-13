using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter value");
        int val = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Centimeter value is"+ (val*2.54));

    }
}