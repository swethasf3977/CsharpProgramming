using System;
namespace AssignmentOperators;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter first number:");
        int value1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Second number:");
        int value2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Addition"+" "+(value1+value2));
        System.Console.WriteLine("Subtraction"+" "+(value1-value2));
        System.Console.WriteLine("Division"+" "+value1/value2);
        System.Console.WriteLine("Multiplication"+" "+value1*value2);
        System.Console.WriteLine("Modular"+" "+value1%value2);
    }
}