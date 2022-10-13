using System;
namespace SumPercentage;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter physics mark:");
        int mark1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Chemistry mark:");
        int mark2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Maths mark:");
        int mark3 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Sum"+(mark1+mark2+mark3));
         System.Console.WriteLine("Average"+((mark1+mark2+mark3)/3));
    }
}