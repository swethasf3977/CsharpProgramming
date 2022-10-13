using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your string");
        string str1 = Console.ReadLine();
        System.Console.WriteLine("Enter second string");
        string str2 = Console.ReadLine();
        if(str1.Length == str2.Length)
        {
            for (int i =0; i<=str1.Length-1;i++)
            {
               Console.WriteLine(str1.Contains(str2[i]));
            }
            System.Console.WriteLine("Two Strings are anagram");

        }
        else
        {
            System.Console.WriteLine("Not anagram");
        }
    
    }
}