using System;
namespace Array3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of array");
        int size = int.Parse(Console.ReadLine());
        int count =0;
        for (int i = 0; i<=size-1 ;i++)
        {
            System.Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            count +=num;
        }
        System.Console.WriteLine(count);
        
    }
}