using System;
namespace ReadWrite;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter your name:");
        string myName = Console.ReadLine();
        System.Console.WriteLine("Enters yours father name:");

        string fatherName = Console.ReadLine();

        //concatation
        System.Console.WriteLine("My name is " +myName + " "+"My father name is"+" " +fatherName);
        //place holder
        System.Console.WriteLine("My name is: {0} and my father name is {1}",myName,fatherName);
        //Interpolation
        System.Console.WriteLine($"My name is: {myName} and my father name is {fatherName}");
    }
}