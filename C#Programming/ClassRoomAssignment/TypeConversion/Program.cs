using System;
namespace TypeConversion
{
    class Program
    {
     public static void Main(string[] args)
     {
        int age;
        int mark1;
        int mark2;
        int mark3;
        char grade;
        long phone;
        float cgpa;
    
       System.Console.WriteLine("Enter student name:");
       string name = Console.ReadLine();
       System.Console.WriteLine("Enter age:");
       age = int.Parse(Console.ReadLine());
       System.Console.WriteLine("Enter mark1:");
       mark1 = int.Parse(Console.ReadLine());
       System.Console.WriteLine("Enter mark2:");
       mark2 = int.Parse(Console.ReadLine());
       System.Console.WriteLine("Enter your mark3:");
       mark3 = int.Parse(Console.ReadLine());
       System.Console.WriteLine("Enter your mail id:");
       string mail = Console.ReadLine();
       System.Console.WriteLine("Enter your phone number:");
       phone = long.Parse(Console.ReadLine());
       System.Console.WriteLine("Grade :");
       grade = char.Parse(Console.ReadLine());
       System.Console.WriteLine("CGPA :");
       cgpa = float.Parse(Console.ReadLine());
       System.Console.WriteLine("Total "+(mark1+mark2+mark3));
       float avg = (float) (mark1+mark2+mark3)/3;
       System.Console.WriteLine("Average "+avg);
     }
    }
}