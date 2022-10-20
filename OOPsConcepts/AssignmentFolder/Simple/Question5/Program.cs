using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
       int basic =10000;
       int da = 10/100;
       int hra = 10/100;
       int tax = 5/100;
       System.Console.WriteLine("Annual salary is"+((basic+da+hra)-tax));

    }
}