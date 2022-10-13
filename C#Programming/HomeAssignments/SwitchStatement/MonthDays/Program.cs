using System;
namespace MonthDays;
class Program
{
    public static void Main(string[] args)

    {
        // Switch with int 
        System.Console.WriteLine("Select Month :\n 1.January \n 2.February \n 3.March \n 4.April \n 5.May \n 6.June \n 7.July \n 8.August \n 9.Septemper \n 10.Octobar \n 11.November \n 12.December");
        int choice1 = int.Parse(Console.ReadLine());
        switch (choice1)
        {
            case 1:
            {
                System.Console.WriteLine(" 31 days");
                break;
            }
            case 2:
            {
                System.Console.WriteLine("28 days");
                break;
            
            }
            case 3:
            {
               System.Console.WriteLine("31 days");
                break;
            }
             case 4:
            {
               System.Console.WriteLine("30 days");
                break;
            }
             case 5:
            {
               System.Console.WriteLine("31 days");
                break;
            }
             case 6:
            {
               System.Console.WriteLine("30 days");
                break;
            }
             case 7:
            {
               System.Console.WriteLine("31 days");
                break;
            }
             case 8:
            {
               System.Console.WriteLine("31 days");
                break;
            }
             case 9:
            {
               System.Console.WriteLine("30 days");
                break;
            }
             case 10:
            {
               System.Console.WriteLine("31 days");
                break;
            }
             case 11:
            {
               System.Console.WriteLine("30 days");
                break;
            }
             case 12:
            {
               System.Console.WriteLine("31 days");
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