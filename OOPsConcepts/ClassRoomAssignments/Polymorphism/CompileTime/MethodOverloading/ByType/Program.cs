using System;
namespace ByType;
class Program 
{ 
    static void Display(int number)
    {
        System.Console.WriteLine("int type "+number);

    }
    //method with two parameter
    static void Display(string name)
    {
        System.Console.WriteLine("String type "+name);

    }
    public static void Main(string[] args)
    {
        Display(9);
        Display("swetha");
        Console.ReadLine();
        
        
    }
}