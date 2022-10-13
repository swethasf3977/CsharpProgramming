using System;
namespace String;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter string");
        string val1 = Console.ReadLine();
        for (int i =val1.Length-1; i >= 0; i--)
        {
            System.Console.Write(val1[i]+" ");
        }
    }
}