using System;
namespace DoWhile4;
class Program
{
    public static void Main(string[] args)
    {   
        int number;
        System.Console.WriteLine("Enter Input");  
        bool temp = int.TryParse(Console.ReadLine(),out number);
      do 

        { 
            if (temp)
            {
                if( number >=1 && number <=5)

                 {
                    System.Console.WriteLine("Valid input");
                    break;
                 }
                 else
                  {
                    System.Console.WriteLine("Invalid input");
                    System.Console.WriteLine("Enter Number");
                    temp = int.TryParse(Console.ReadLine(),out number);
                  }

            }
            else 
            {
                    System.Console.WriteLine("Invalid input");
                    System.Console.WriteLine("Enter Number");
                    temp= int.TryParse(Console.ReadLine(),out number);
            }
    
        }while(true);
       
    }
}