using System;
namespace Findab;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a ");
        int a = int.Parse(Console.ReadLine());
         System.Console.WriteLine("Enter b ");
        int b = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Answer"+((a*a)+(2*a*b)+(b*b)));
    }
}