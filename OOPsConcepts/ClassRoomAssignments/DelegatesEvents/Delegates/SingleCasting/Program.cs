using System;
namespace SingleCasting;
public delegate int Calculator(int value);    //can add methods int return type & int arg
class Program 
{
    static int value = 10;
    public static int Add(int number) {value +=number;return value;}
    public static int Multiply(int number) {value *=number;return value;}
    public static int GetNum(){return value;}
    public static void Main(string[] args)
    {
        //create delegate instaces or objects
        Calculator nc1 =new Calculator(Add);
        Calculator nc2 = new Calculator(Multiply);
        //callung mehtos directly
         System.Console.WriteLine(Add(10)); 
        //calling using delegate objects
        System.Console.WriteLine("Output"+nc1(10));
        System.Console.WriteLine("Value of num : {0} ",GetNum());
        System.Console.WriteLine("Output "+nc2(20));
        System.Console.WriteLine("Value of num : {0} ",GetNum());
        Console.ReadKey();
        
        
    }
}