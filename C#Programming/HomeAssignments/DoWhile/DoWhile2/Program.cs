using System;
namespace Dowhile2;
class Program 
{
    public static void Main(string[] args)
    {
        int count = 0;
        int value;
        do
        {
           System.Console.WriteLine("Enter value");
           value = int.Parse(Console.ReadLine());
           count +=value;       

        }while( count <=100);
       
        System.Console.WriteLine(count);
       
    }
}