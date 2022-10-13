using System;
namespace Dowhile1;
class Program 
{
    public static void Main(string[] args)
    {
        
        string condition ="";
        do
        {
           System.Console.WriteLine("Enter value");
           int val = int.Parse(Console.ReadLine());
            if(val%2 ==0)
            {
                System.Console.WriteLine("Even Number");
                
            }
            else
            {
                System.Console.WriteLine("Odd Number");
            }
           System.Console.WriteLine("Do you want print another number?");
           condition = Console.ReadLine();
                   
        }while(condition == "yes");
      
        
    }
}