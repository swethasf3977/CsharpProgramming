using System;
namespace Fibonaci;
class Program
{
    public static void Main(string[] args)
    {  
         int a = 0;
        int b = 1;
        int i = 3;
        int c ;
        System.Console.WriteLine("Enter Count");
        int count = int.Parse(Console.ReadLine());
        System.Console.Write("{0} {1}",a,b);

        while (i <=count)
        {
           
            c=a+b;
            System.Console.Write(" "+c);
            a=b;
            b=c;
            i++;  

        }
          
        
    }
}