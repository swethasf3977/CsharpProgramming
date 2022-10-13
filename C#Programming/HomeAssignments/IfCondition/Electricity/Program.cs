using System;
namespace Electricity;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Cutomer name");
        string name = Console.ReadLine();
        System.Console.WriteLine("Enter Cutomer ID");
        int id = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter unit");
        int unit = int.Parse(Console.ReadLine());
        if (unit > 0)
        {
            if (unit >=1 && unit <=50)
            {
                System.Console.WriteLine("Amount 100");
            }
            else if (unit >= 51 && unit <=199)
            {
                System.Console.WriteLine("Amount charges @Rs.1.20.00 per unit:"+(unit*1.20));
            }
             else if (unit >= 200 && unit <=399)
            {
                System.Console.WriteLine("Amount charges @Rs.1.50 per unit:"+(unit*1.50));
            }
            else if (unit >= 400 && unit <=599)
            {
                double unit1 = unit*1.80;
                double surcharge = unit1 *0.15;
                double netAmount = surcharge + unit1;
                System.Console.WriteLine("Amount charges @Rs.1.80 per unit:"+unit1);
                System.Console.WriteLine("Surcharge Amount"+surcharge);
                System.Console.WriteLine("Net Amount"+netAmount);
            }
        
             else
            {
                double unit2 = unit*2.00;
                double surcharge2 = unit2 *0.15;
                double netAmount2 = surcharge2 + unit2;
                System.Console.WriteLine("Amount charges @Rs.1.80 per unit:"+unit2);
                System.Console.WriteLine("Surcharge Amount"+surcharge2);
                System.Console.WriteLine("Net Amount"+netAmount2);
               
            }
        }
        else
        {
            System.Console.WriteLine("Invalid unit");
        }
         
            
     }
    }
