using System;
namespace Array2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of array");
        int size = int.Parse(Console.ReadLine());
        
        
        for (int i = size-1; i>=0 ;i--)
        {
            System.Console.WriteLine(i);
           
        }
    }
}