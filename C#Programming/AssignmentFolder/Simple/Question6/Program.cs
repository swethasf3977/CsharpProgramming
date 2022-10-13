using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Password");
        string pass = Console.ReadLine();
        if (pass=="s3cr3t!P@ssw0rd")
        {
            System.Console.WriteLine("Welcome");
        }
        else
        {
          System.Console.WriteLine("Wrong Password");
        }
        
    }
}