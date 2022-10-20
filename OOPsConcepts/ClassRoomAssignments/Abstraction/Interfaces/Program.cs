using System;
namespace Interfaces;
class Program 
{
    public static void Main(string[] args)
    {
        Square number = new Square();  //calss variable as object
        number.Number =10;
        System.Console.WriteLine(number.Calculate());
        ICalculate value = new Square(); //interface variable as object
        value.Number = 20;
        System.Console.WriteLine(value.Calculate());
    }
}
