using System;
namespace Question13;
class Program
{
    public static void Main(string[] args)
    {   System.Console.WriteLine("enter row");
    int row = int.Parse(Console.ReadLine());
        for(int i=1;i<=row;i++)
        {
            for(int j = 1; j<=i; j++)
            { System.Console.Write(" ");

            }
            System.Console.Write(row);
        }
    }
}