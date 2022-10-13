using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
      System.Console.WriteLine("Enter value");
      int val = int.Parse(Console.ReadLine());
      if(val <= 99)
      {
        System.Console.WriteLine("Less then 100");
      }
      else if (val >=100 && val <=119)
      {
        System.Console.WriteLine("Between 100 and 120");
      }
      else
      {
        System.Console.WriteLine("Greater than 200");
      }
        
        
    }
}