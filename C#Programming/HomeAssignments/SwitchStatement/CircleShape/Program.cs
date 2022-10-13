using System;
namespace CircleShape;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Radius of the Circle");
        int radius = int.Parse(Console.ReadLine());
    
        System.Console.WriteLine("Enter the option: \n 1.Area \n 2.Perimeter \n 3.Diameter");
        int option = int.Parse(Console.ReadLine());
        
        switch (option)
        {
            case 1:
            {
              double area = (3.14)* radius*radius;
              System.Console.WriteLine(area);
               break;
            }
            case 2:
            {
               System.Console.WriteLine("Perimeter"+(2*3.14*radius));
               break;

            }
             case 3:
            {
               System.Console.WriteLine("Diameter"+(2*radius));
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
