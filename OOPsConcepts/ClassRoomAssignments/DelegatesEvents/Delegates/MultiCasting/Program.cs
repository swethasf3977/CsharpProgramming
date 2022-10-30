using System;
namespace MultiCasting;
delegate int Calculator(int value);    //can add methods int return type & int arg
class Program 
{
    static int value = 10;
    public static int Add(int number) {value +=number;return value;}
    public static int Multiply(int number) {value *=number;return value;}
    public static int GetNum(){return value;}
    public static void Main(string[] args)
    {
        //multicasting
        Calculator nc;
        nc = new Calculator(Add);
        nc += new Calculator(Multiply);
        nc(5);
        //caling multicasting
        System.Console.WriteLine("value {0} ",GetNum());
        Console.ReadKey();
        
        
        
    }
}
