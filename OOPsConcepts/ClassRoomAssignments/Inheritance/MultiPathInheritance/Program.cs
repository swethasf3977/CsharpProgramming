using System;
namespace MultiPathInheritance;
class Program 
{
    public static void Main(string[] args)
    {
        Student student = new Student("Swetha",90,90);
        student.Display();
        Console.ReadKey();
              
    }
}