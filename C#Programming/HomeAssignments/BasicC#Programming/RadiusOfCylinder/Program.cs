using System;
namespace RadiusOfCylinder;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter height");
        int value = int.Parse(Console.ReadLine());
         System.Console.WriteLine("Enter radius");
        int value1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Radius"+(3.14*value1*value1*value));
       

    }
}