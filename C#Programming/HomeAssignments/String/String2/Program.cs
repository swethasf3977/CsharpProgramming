using System;
namespace String2;
class Program 
{
    public static void Main(string[] args)
    {  
      System.Console.WriteLine("Enter string");
      string str = Console.ReadLine();
      for(int i = 0; i <= str.Length-1; i++)
      {
        System.Console.Write(str[i]+" ");

      }
     

    }
}