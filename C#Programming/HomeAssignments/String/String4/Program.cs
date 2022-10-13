using System;
namespace String4;
class Program 
{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter the string");
       string str = Console.ReadLine();
       string[] str1 = str.Split(' ');
       int count =0;
        foreach (string sub in str1)
        {
           count++;
        }
        System.Console.WriteLine(count);

    }
}