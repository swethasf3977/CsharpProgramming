using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius");
       float val = float.Parse(Console.ReadLine());   
       
        System.Console.WriteLine("Area of circle"+(3.14*val*val));
        System.Console.WriteLine("Perimeter"+(2*3.14*val));
    }
}