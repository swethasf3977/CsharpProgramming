using System;
namespace TaxProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter price");
        int price = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Total"+(price+(price*0.18)));

    }
}