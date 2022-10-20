using System;
namespace ExceptionHandling;
class Program 
{
    public static void Main(string[] args)
    {

        try
        {
        System.Console.WriteLine("Enter Number 1");
        int number1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Number 2");
        int number2 = int.Parse(Console.ReadLine());
        int result = number1/number2;

        }
         
        catch (FormatException e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);

        }
        catch(DivideByZeroException e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
        }
       catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
        }
       
        finally
        {
            System.Console.WriteLine("All exception handled");
        }
    }
}
