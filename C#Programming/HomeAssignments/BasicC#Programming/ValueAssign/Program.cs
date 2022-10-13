using System;
namespace ValueAssign;
class Program
{
    public static void Main(string[] args)
    {
        int value1 = 15,value2 = 20;
        System.Console.WriteLine(value1 > value2);
        System.Console.WriteLine(value1 < value2);
        System.Console.WriteLine(value1 >= value2);
        System.Console.WriteLine(value1 == value2);
        System.Console.WriteLine(value1 <= value2);
        System.Console.WriteLine(value1 != value2);
        System.Console.WriteLine(value1 >= 10 && value2 >= 10);
        System.Console.WriteLine(value1 >= 10 || value2 >= 30);
        System.Console.WriteLine(!(value1 >20));
        System.Console.WriteLine(value1 == 15 ? "True" : "False");
         System.Console.WriteLine(value1 ++);
         System.Console.WriteLine(value1 --);
            }
}