using System;
namespace SumNumbers;
class Program 
{
    public static void Main(string[] args)
    {
      int i = 1;
      System.Console.WriteLine("Enter count");
      int count = int.Parse(Console.ReadLine());
      int sum = 0;
       while (i <= count)    
       {
        System.Console.WriteLine(i);  
        sum = sum +(i*i);
        i++;

        }
        System.Console.WriteLine(sum);
       
        }
        
    }
