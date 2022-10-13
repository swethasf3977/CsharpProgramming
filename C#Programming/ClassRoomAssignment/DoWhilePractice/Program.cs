using System;
namespace DoWhilePractice;
class Program 
{
    public static void Main(string[] args)
    {   string eat ="";
        do 
        {
            System.Console.WriteLine("Eat food");
            System.Console.WriteLine("Feel hungry?");
             eat = Console.ReadLine();
        }while(eat == "yes");
      
    }
}