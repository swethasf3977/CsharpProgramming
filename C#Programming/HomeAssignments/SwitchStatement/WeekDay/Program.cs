using System;
namespace WeekDays;
class Program
{
    public static void Main(string[] args)

    {
        // Switch with int 
        System.Console.WriteLine("Enter your choice :\n 1.Monday \n 2.Tuesday \n 3.Wednesday \n 4.Thursday \n 5.Friday \n 6.Saturday \n 7.Sunday");
        int choice1 = int.Parse(Console.ReadLine());

        switch (choice1)
        {
            case 1:
            {
                System.Console.WriteLine("Monday");
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Tueday");
                break;
            
            }
            case 3:
            {
               System.Console.WriteLine("wednesday");
                break;
            }
            case 4:
            {
               System.Console.WriteLine("Thursday");
                break;

            }
            case 5:
            {
               System.Console.WriteLine("Friday");
                break;
            }
            case 6:
            {
               System.Console.WriteLine("Saturday");
                break;
            }
            case 7:
            {
               System.Console.WriteLine("Sunday");
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