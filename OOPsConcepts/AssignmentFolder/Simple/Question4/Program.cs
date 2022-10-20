using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter INR");
        int val = int.Parse(Console.ReadLine());
        System.Console.WriteLine("USD"+(val/1.12));
         System.Console.WriteLine("Euro"+(val/1.27));
        System.Console.WriteLine("CNY"+(val/8.79));
        
    }
}