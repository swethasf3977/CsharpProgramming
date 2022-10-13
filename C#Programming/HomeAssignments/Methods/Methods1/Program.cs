using System;
namespace Methods1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter First value");
        int value1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Second value");
        int value2 = int.Parse(Console.ReadLine());

          void Addition(int value1, int value2)
            {
                System.Console.WriteLine("The sum value is"+(value1+value2));
            }
            Addition(value1,value2);
             

            void Subraction(int value1, int value2)
            {
                System.Console.WriteLine("Subtraction"+(value1-value2));
            }
             Subraction(value1,value2);
              
              
            void Division(int value1,int value2)
            {
                System.Console.WriteLine("Division"+(value1/value2));
            }
            Division(value1,value2);
            
               
            void Multiplication(int value1,int value2)
            {
                System.Console.WriteLine("Multiplication"+(value1*value2));
            }
             Multiplication(value1,value2);       
        

    }
}