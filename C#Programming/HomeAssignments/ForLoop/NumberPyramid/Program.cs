using System;
namespace PrintPyramid;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number of rows");
        int numberOfRows= int.Parse(Console.ReadLine());
        int count = 1;
        for (int row = 1; row <= numberOfRows ; row++)
        {   
             for(int i =numberOfRows-1; i-row>=0; i--) 
              {           
                  System.Console.Write(" ");
               }
              for(int col = 1; col <=row; col++)
              {
              
               System.Console.Write(count+" "); 
               count ++;
              }
            
              System.Console.WriteLine();
              
           
        }
    }
}