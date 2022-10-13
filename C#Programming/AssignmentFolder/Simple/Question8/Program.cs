using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Value");
       float val = float.Parse(Console.ReadLine());
        if (val <=10)
        {
            System.Console.WriteLine("Slow");
        }
        else if (val >= 11 && val <= 50)
        {
            System.Console.WriteLine("Average");
        }
        else if (val >= 51 && val <= 150)
        {
            System.Console.WriteLine("Fast");
        }
        else if (val >= 151 && val <= 1000)
        {
            System.Console.WriteLine("Ultra Fast");
        }
        else
        {
            System.Console.WriteLine("Extremely Fast");
        }
    }
}