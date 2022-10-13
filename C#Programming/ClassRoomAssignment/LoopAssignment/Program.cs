using System;
namespace ReadWrite;
class Program
{
    public static void Main(string[] args)
    {
        //print even numbers
        for(int i=0; i<25; i++)
        {
            if(i%2==0)
            { System.Console.WriteLine("Even Numbers "+i);

            }
          
        }
       //print sum of square
       System.Console.WriteLine("Enter start value:");
       int value1 = int.Parse(Console.ReadLine());
       System.Console.WriteLine("Enter ende value:");
       int value2 = int.Parse(Console.ReadLine());
        int sum = 0;
       for(int j = value1; j <= value2 ; j++)
       {
       System.Console.WriteLine("Square of the limits"+j*j);
       sum += j*j;
       }
         System.Console.WriteLine("sum"+sum);
   


    }
}