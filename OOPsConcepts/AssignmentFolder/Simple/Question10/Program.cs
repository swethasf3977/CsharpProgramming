using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a charecter");
        char val = char.Parse(Console.ReadLine().ToUpper());
        switch (val)
        {
            case 'A':
            {
                System.Console.WriteLine("Vowel Letter");
                break;
             } 
              case 'E':
            {
                System.Console.WriteLine("Vowel Letter");
                break;
             } 
              case 'I':
            {
                System.Console.WriteLine("Vowel Letter");
                break;
             } 
              case 'O':
            {
                System.Console.WriteLine("Vowel Letter");
                break;
             } 
              case 'U':
            {
                System.Console.WriteLine("Vowel Letter");
                break;
             } 
             default:
             {
                System.Console.WriteLine("Its not vowel");
                break;
             } 
              
        }
    }
}