using System;
namespace Question3;
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Enter your date of birth dd/MM/yyyy HH:mm:ss format");
         DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy  HH:mm:ss", null);// Parse exact
        Console.WriteLine(dob.ToString("dd/MM/yyyy"));

         Console.WriteLine(dob.Day);       
            Console.WriteLine(dob.Month);      
            Console.WriteLine(dob.Year);
            Console.WriteLine(dob.Hour);         
            Console.WriteLine(dob.Minute);      
            Console.WriteLine(dob.Second);
            Console.WriteLine(dob.Millisecond);
    }
}