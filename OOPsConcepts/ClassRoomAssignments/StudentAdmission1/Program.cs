using System;
using System.Collections.Generic;
namespace StudentAdmission1;
class Program 
{
    public static void Main(string[] args)
    {
        Files.Create();
       // Files.ReadLine();
        Operations.DefaultData();
        Operations.MainMenu();
        Files.WriteToFiles();
        
           

     }
          
        
}
