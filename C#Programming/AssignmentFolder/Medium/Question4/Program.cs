using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the upper limit");
        int a = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the upper limit");
        int b = int.Parse(Console.ReadLine());
        int sum = 0;
       
        for (int i = a; i<=b; i++)
        {

            while (a > 0)
                   {  
                        int rem = a %10;
                        sum = sum + (rem*rem*rem);
                        a = a/10;

                     }
                      if (i == sum)
                            {
                                System.Console.WriteLine(i);
                            }

        }
      

    }
}
