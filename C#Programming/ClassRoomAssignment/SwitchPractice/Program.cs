using System;
namespace SwitchPractice;
class Program
{
    public static void Main(string[] args)

    {
        // Switch with int 
        System.Console.WriteLine("Enter your choice : \n 1.Tea \n 2.Cofee \n 3.Milk");
        int choice1 = int.Parse(Console.ReadLine().ToUpper());

        switch (choice1)
        {
            case 1:
            {
                System.Console.WriteLine("Tea Selected");
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Cofee selected");
                break;
            
            }
            case 3:
            {
               System.Console.WriteLine("Milk selected");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid");
                break;
            }
        }

         System.Console.WriteLine("Enter your choice :\n A.Tea \n B.Cofee \n C.Milk");
         char choice2= char.Parse(Console.ReadLine().ToUpper());

        switch (choice2)
        {
            case 'A':
            {
                System.Console.WriteLine("Tea Selected");
                break;
            }
            case 'B':
            {
                System.Console.WriteLine("Cofee selected");
                break;
            
            }
            case 'C':
            {
               System.Console.WriteLine("Milk selected");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid");
                break;
            }
        }





       //switch with string
        System.Console.WriteLine("Enter your choice :");
        string choice = (Console.ReadLine().ToUpper());

        switch (choice)
        {
            case "TEA":
            {
                System.Console.WriteLine("Tea Selected");
                break;
            }
            case "COFEE":
            {
                System.Console.WriteLine("Cofee selected");
                break;
            
            }
            case "MILK":
            {
               System.Console.WriteLine("Milk selected");
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