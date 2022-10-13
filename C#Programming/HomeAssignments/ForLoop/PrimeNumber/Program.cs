using System;
namespace PrimeNumber;
class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        System.Console.WriteLine("Enter value");
        int value = int.Parse(Console.ReadLine());
        for ( int i = 1; i<=value ; i++)
        {
            if (value % i == 0)
                {
                    count++;     
                }
            }
        
         if(count == 2)
        {
            System.Console.WriteLine("Prime");
        }
        else
        {
            System.Console.WriteLine("Not Prime");
        }

        
    }
}