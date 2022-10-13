using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        string DateString1= "29/04/2022 11:49:00 AM " ;
        
        Console.WriteLine(DateString1.ToString("dd/MM/yyyy HH:mm:ss"));
        Console.WriteLine(DateString1.ToShortDateString());        
            Console.WriteLine(DateString1.ToLongDateString()); 
    }
}