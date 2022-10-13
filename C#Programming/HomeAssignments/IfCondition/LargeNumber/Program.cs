using System;
namespace LargeNumber;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a value");
        int a = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter b value");
        int b = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter c value");
        int c = int.Parse(Console.ReadLine());
        if (a>b && a>c)
        {
            System.Console.WriteLine("a is large number");
        }
        else if (b>a && b>c)
        {
            System.Console.WriteLine("b is large number");
        }
        else
        {
              System.Console.WriteLine("c is large number");
        }
    }
}
