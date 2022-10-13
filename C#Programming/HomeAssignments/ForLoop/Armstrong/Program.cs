using System;
namespace Armstrong;
class program

{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Value");
        int value = int.Parse(Console.ReadLine());
        int temp = value;
        int sum = 0;
        while (temp > 0)
        {  
           
           int rem = temp %10;
           sum = sum + (rem*rem*rem);
           temp = temp/10;

        }
        if (value == sum)
        {
        System.Console.WriteLine("Armstrong");
        }
        else
        {
        System.Console.WriteLine("Not Armstrong");
        }        
        
    }
}