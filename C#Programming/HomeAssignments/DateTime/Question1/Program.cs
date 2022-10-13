using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {   
         DateTime today = DateTime.Now;            
         Console.WriteLine(today.ToString());
         Console.WriteLine(today.ToString("dd/MM/yyyy hh:mm:ss tt"));
        
    }
}