using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Starting number");
        int num1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Difference");
        int diff = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter limits");
        int limit = int.Parse(Console.ReadLine());

        for (int i = 2; i<=limit ; i++)
        {
            
                System.Console.Write(num1);
                System.Console.Write(num1+diff);
          

        }




    }
}