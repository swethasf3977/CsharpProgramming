using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Enter your date of birth dd/MM/yyyy format");
        DateTime date= DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.WriteLine(date.ToString("dd/MM/yyyy"));
        DateTime today = DateTime.Now;
        System.Console.WriteLine(today);
        if (date == today)
        {
            System.Console.WriteLine("True");

        }
        else 
        {
            System.Console.WriteLine("False");
        }

    }
}