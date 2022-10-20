using System;
namespace Methods3;
class Program 
{
  public static void Main(string[] args)
  {
   
    void Display()

    {
        System.Console.WriteLine("Enter first number");
        int a = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter second number");
        int b = int.Parse(Console.ReadLine());
        int temp;
        temp = a;
        a = b;
        b = temp;
        System.Console.WriteLine("After swap \n a = "+a + "\n b = "+b);

    }
      Display();


  }

}