using System;
namespace DoWhileAssignment;
class Program
{
    public static void Main(string[] args)
    {
        string condition ="";
        do
        {
           System.Console.WriteLine("Enter value");
           int val = int.Parse(Console.ReadLine());
           System.Console.WriteLine("Do you want print another number?");
           condition = Console.ReadLine();
                   
        }while(condition == "yes");
      
         if (condition != "yes" && condition!="no")
           {
               System.Console.WriteLine("Invalid input give correct input");
             
             }
    }
}