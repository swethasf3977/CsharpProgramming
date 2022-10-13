using System;
namespace CubeNumber;
class Program
{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter count");
       int count = int.Parse(Console.ReadLine());
        for (int i = 1 ; i <=count ; i++)
        {
            System.Console.WriteLine("Number is : " + i +" and cube of the " + i +" "+ "is"+" "+(i*i*i));

        }
    }
}