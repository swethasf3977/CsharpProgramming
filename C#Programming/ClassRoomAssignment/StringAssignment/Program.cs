using System;
namespace StringAssignment;
class Program 
{
    public static void Main(string[] args)
    {  
        System.Console.WriteLine("Enter your string");
        string val1 =Console.ReadLine();
        System.Console.WriteLine("Enter your second string");
        string val2 =Console.ReadLine();
        string[] splitchar =val1.Split(val2);
    
         System.Console.WriteLine(splitchar.Length-1);
        


    }
}