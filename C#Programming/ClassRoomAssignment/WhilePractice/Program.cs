using System;
namespace WhilePractice;
class Program
{
    public static void Main(string[] args){
    System.Console.WriteLine("Are you feel hungry?");
    string eat = Console.ReadLine();
    while (eat =="yes")
    {
        System.Console.WriteLine("eat food");

        System.Console.WriteLine("Still you hungry?");
         eat = Console.ReadLine();
        
    }

    }
        
    
}
