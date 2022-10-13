using System;
namespace GradeDeclare;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Select Grade \n E.Excelent \n V.VeryGood \n G.Good \n A.Average \n F.Fail");
        Char choice  = char.Parse(Console.ReadLine().ToUpper());
        switch (choice)
        {
            case 'V':
            {
                System.Console.WriteLine("Very Good");
                break;

            }
             case 'G':
            {
                System.Console.WriteLine("Good");
                break;

            }
             case 'A':
            {
                System.Console.WriteLine("Average");
                break;

            }
             case 'F':
            {
                System.Console.WriteLine("Fail");
                break;

            }
             case 'E':
            {
                System.Console.WriteLine("Excellent");
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