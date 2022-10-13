using System;
namespace WhileAssign;
class Program
{
    public static void Main(string[] args)
    {
        //print even number
       
        int i= 0;

        while (i<=25)
        {
            if(i%2 == 0)
            {
                System.Console.WriteLine(i);
                            
            }
            i++;
        }
        // print valid invalid
        int number ;
        System.Console.WriteLine("Enter number");
        bool temp = int.TryParse(Console.ReadLine(),out number);
        while(!temp)
        {
            System.Console.WriteLine("Invalid input enter correct input");
             temp = int.TryParse(Console.ReadLine(),out number);
           
    
        }
           System.Console.WriteLine("Valid input"+number);
        
    }
}