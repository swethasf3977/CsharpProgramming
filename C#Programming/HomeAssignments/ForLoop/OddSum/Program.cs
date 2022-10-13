using System;
namespace OddSum;
class Program
{
    public static void Main(string[] args)
    {   int sum = 0;
        System.Console.WriteLine("Enter Count");
        int count = int.Parse(Console.ReadLine());
        for(int i=1;i<=(count*2);i++)
        {
            if ( i%2 != 0)
            {
                System.Console.WriteLine("The Odd Numbers are"+i);
                sum +=i;           

            }
         
        }
    
        System.Console.WriteLine("Sum of Odd"+sum );
    }
}