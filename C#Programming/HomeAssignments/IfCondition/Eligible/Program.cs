using System;
namespace Eligible;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Physics Mark");
        int mark1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Chemistry Mark");
        int mark2 = int.Parse(Console.ReadLine());
         System.Console.WriteLine("Enter Maths Mark");
        int mark3 = int.Parse(Console.ReadLine());
        if (((mark1+mark2+mark3)/3 >= 75))
        {
        System.Console.WriteLine("Eligible for admission");
        }
        else
        {
            System.Console.WriteLine("Not Eligible");
        }
    }
}