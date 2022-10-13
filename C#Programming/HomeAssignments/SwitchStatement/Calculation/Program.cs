using System;
namespace Calculation;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter first value");
        int value1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter second value");
        int value2 = int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the option: \n 1.Addtion \n 2.Subtraction \n 3.Multiplication \n 4.Division");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            {
              System.Console.WriteLine("Addition"+" " +(value1+value2));
               break;
            }
            case 2:
            {
               System.Console.WriteLine("Subtraction"+ " " +(value1-value2));
               break;

            }
             case 3:
            {
               System.Console.WriteLine("Multiplication"+ " "+(value1*value2));
               break;

            }
             case 4:
            {
               System.Console.WriteLine("Division"+ " "+(value1/value2));
               break;

            }
            default:
            {
               System.Console.WriteLine("Invalid");
               break;

            }

        }


    }
}