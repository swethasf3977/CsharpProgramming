using System;
namespace SumAverage;
class Program
{
    public static void Main(string[] args)
    {
        
        int sum = 0;
        for ( int count = 1; count <=10 ; count++)
        {
            System.Console.WriteLine(count);
            sum += count;
                 
        }
        System.Console.WriteLine("Sum"+sum);
        float avg = sum/10;
        System.Console.WriteLine("Average"+avg);
    }
}