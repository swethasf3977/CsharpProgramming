using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter terms");
        int count = int.Parse(Console.ReadLine());
        int a =0;
        int b =1;
        int c ;
         System.Console.Write("{0} {1}" ,a,b);       
        for (int i = 3 ; i <= count ; i++)
        {
            c = a+b;
            System.Console.Write(" "+c);
            a = b;
            b=c;
          

        }
        
    }
}