using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Month Name : \n 1.january \n 2.february \n 3.March \n 4.April \n 5.May \n 6.June \n 7.july \n 8.August \n 9.sebtember \n 10.octobar \n 11.November \n 12.december");
        int choise = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Leaves in the month");
        int leave = int.Parse(Console.ReadLine());
        switch (choise)
        {  case 1:
              {
                System.Console.WriteLine("Salary"+((31-leave)*500));
                break;
              }
              case 2:
              {
                System.Console.WriteLine("Salary"+((28-leave)*500));
                break;
              }
              case 3:
              {
                System.Console.WriteLine("Salary"+((31-leave)*500));
                break;
              }
              case 4:
              {
                System.Console.WriteLine("Salary"+((30-leave)*500));
                break;
              }
              case 5:
              {
                System.Console.WriteLine("Salary"+((31-leave)*500));
                break;
              }
              case 6:
              {
                System.Console.WriteLine("Salary"+((30-leave)*500));
                break;
              }
              case 7:
              {
                System.Console.WriteLine("Salary"+((31-leave)*500));
                break;
              }
              case 8:
              {
                System.Console.WriteLine("Salary"+((31-leave)*500));
                break;
              }
              case 9:
              {
                System.Console.WriteLine("Salary"+((30-leave)*500));
                break;
              }
             case 10:
              {
                System.Console.WriteLine("Salary"+((31-leave)*500));
                break;
              }
              case 11:
              {
                System.Console.WriteLine("Salary"+((30-leave)*500));
                break;
              }
              case 12:
              {
                System.Console.WriteLine("Salary"+((31-leave)*500));
                break;
              }
              default:
              {
                System.Console.WriteLine("Invalid input");
                break;

              }



        }
       
     
       
    }
}