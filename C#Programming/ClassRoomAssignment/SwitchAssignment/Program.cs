using System;
namespace SwitchAssignment;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter first value");
        int value1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter second value");
        int value2 = int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the option: \n 1.Add(+) \n 2.Sub(-) \n 3.Multiply(*) \n 4.Div(/) \n 5.Mod(%)");
        char choice = char.Parse(Console.ReadLine());
        switch (choice)
        {
            case '+':
            {
              System.Console.WriteLine("Addition"+" " +(value1+value2));
               break;
            }
            case '-':
            {
               System.Console.WriteLine("Subtraction"+ " " +(value1-value2));
               break;

            }
             case '*':
            {
               System.Console.WriteLine("Multiplication"+ " "+(value1*value2));
               break;

            }
             case '/':
            {
               System.Console.WriteLine("Division"+ " "+(value1/value2));
               break;

            }
            case '%':
            {
               System.Console.WriteLine("Modulo Division"+ " " +(value1%value2));
               break;

            }




        }


    }
}