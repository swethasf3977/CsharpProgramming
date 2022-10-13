using System;
namespace DoWhile3;
class Program
{
    public static void Main(string[] args)
    {
        int a = 0;
        int b =1 ;
        int i =3;
        int d;
        System.Console.WriteLine("Enter count");
        int val = int.Parse(Console.ReadLine());
        System.Console.Write("{0} {1}",a,b);
         
        do
        {
           
            d =a+b;
            System.Console.Write(" "+d);
            a = b;
            b = d;
            i++;
                      
        }while(i <=val);

       
    }
}
      