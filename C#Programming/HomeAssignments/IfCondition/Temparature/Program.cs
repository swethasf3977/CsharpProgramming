using System;
namespace Temparature;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Temp");
        int temp = int.Parse(Console.ReadLine());
        if (temp < 0)
        {
            System.Console.WriteLine("Freezing weather");
        }
        else if ( temp >= 0 && temp <=10)
         {
            System.Console.WriteLine("Very cold weather");
         }   
         else if (temp >=11 && temp <= 20)
         {
            System.Console.WriteLine("Cold Weather");
         }     
          else if (temp >=21 && temp <= 30)
         {
            System.Console.WriteLine("Normal in Temp");
         }     
          else if (temp >=31 && temp <= 39)
         {
            System.Console.WriteLine("Its Hot");
         }     
         else
         {
            System.Console.WriteLine("Its very hot");
         }
         
    }
}