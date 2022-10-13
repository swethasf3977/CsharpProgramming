using System;
namespace MenuDriven;
class Program
{
    public static void Main(string[] args)
    {
        
        System.Console.WriteLine("Enter the option: \n India \n Pakistan \n Banglathesh ");
        String choice = (Console.ReadLine());
        switch (choice)
        {
            case "India":
            {
              System.Console.WriteLine("\n 1.Dhoni \n 2.Jadaja \n 3.Ashwin \n 4.Gambhir");
               break;
            }
            case "Pakistan":
            {
               System.Console.WriteLine("\n 1.Afridi \n 2.Babar \n 3.Rizwan");
               break;

            }
             case "Banglathesh":
            {
               System.Console.WriteLine("\n 1.Sabir \n 2.litton");
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
