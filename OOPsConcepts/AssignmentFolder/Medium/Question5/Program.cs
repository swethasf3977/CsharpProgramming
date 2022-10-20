using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the upper limit");
        int a = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the lower limit");
        int b = int.Parse(Console.ReadLine());
        for (int i=a ; i<=b ;i++)
        {
            if (i%4 == 0 && (i%400 ==0 || i%100 !=0))
            {
                System.Console.WriteLine(i);
            }

        }


    }
}