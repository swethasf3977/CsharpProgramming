using System;
namespace DegreeToFaran;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the value");
        int degree = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Kelvin ="+ " "+ (degree+273.15));
        System.Console.WriteLine("Fahrenheit ="+ " "+ ((degree+9/5)+32));
    }
}