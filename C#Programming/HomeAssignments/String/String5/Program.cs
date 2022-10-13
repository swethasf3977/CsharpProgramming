using System;
namespace String5;
class Program 
{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter the first string");
       string str1 = Console.ReadLine().ToLower();
       System.Console.WriteLine("Enter the first string");
       string str2 = Console.ReadLine().ToLower();
       if (str1==str2)
       {
        System.Console.WriteLine("The length of both strings are equal and also, both strings are equal");
       }
       else 
       {
        System.Console.WriteLine("wrong string");
       }
       

       
    }
}