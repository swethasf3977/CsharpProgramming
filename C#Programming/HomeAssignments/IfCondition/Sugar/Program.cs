using System;
namespace Sugar;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter value");
        int value = int.Parse(Console.ReadLine());
        if(value < 90)
        {
            System.Console.WriteLine("Low Sugar");
        }
        else if (value >=90 && value <=129)
        {
            System.Console.WriteLine("Normal");
        }
        else if (value >=130 && value <=139)
        {
            System.Console.WriteLine("Medium");
        }
        else if (value >=140 && value <=169)
        {
            System.Console.WriteLine("High sugar");
        }
        else
        {
            System.Console.WriteLine("Very high sugar");
        }

    }
}