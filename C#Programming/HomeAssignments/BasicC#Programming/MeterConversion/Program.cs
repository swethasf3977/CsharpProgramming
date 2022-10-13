using System;
namespace MeterConversion;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter meter value ");
        int value = int.Parse(Console.ReadLine());
        System.Console.WriteLine("CM"+(value*100));
        System.Console.WriteLine("Mm"+(value*100*10));
        System.Console.WriteLine("Inch"+(39.3*value));
        System.Console.WriteLine("Floot"+(12*value));
        System.Console.WriteLine("Mile"+(value*0.0006213715277778));
    }
}