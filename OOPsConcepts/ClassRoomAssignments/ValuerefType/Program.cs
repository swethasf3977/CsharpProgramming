using System;
namespace ValuerefType;
class Program 
{
    public static void Main(string[] args)
    {  
        //value type

        int number1 =10;
        int number2 = number1;
        System.Console.WriteLine("Number 1 is " + number1 +"Number 2 is "+number2);

        //reference type
        ClassRef object1;
        object1 = new ClassRef();
        object1.Number = 10;
        ClassRef object2 =object1;
        System.Console.WriteLine("Number 1 is "+ object1.Number+ " Number 2 is "+object2.Number);

        object2.Number = 40;
        System.Console.WriteLine("Number 1 is "+ object1.Number+ " Number 2 is "+object2.Number);   

    }
}