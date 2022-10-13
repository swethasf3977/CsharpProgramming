using System;
namespace String1;
class Program 
{
    public static void Main(string[] args)
    {   int count = 0;
        System.Console.WriteLine("Enter String");
        string str = Console.ReadLine();
        foreach(int i in str)
        {
            count++;

        }
        System.Console.WriteLine(count);
    }
}