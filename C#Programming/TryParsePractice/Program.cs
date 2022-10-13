using System;
namespace TryParsePractice
{
  class Program
  {
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter the number");
        bool temp = int.TryParse(Console.ReadLine(),out number);
        System.Console.WriteLine("The number is"+number);
        System.Console.WriteLine("The bool value"+temp);
        
    }
  }
}
