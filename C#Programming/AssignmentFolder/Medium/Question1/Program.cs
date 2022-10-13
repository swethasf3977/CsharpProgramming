using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter basic salary");
        int basic = int.Parse(Console.ReadLine());
        if(basic <= 10000)
        {
            System.Console.WriteLine("Annual Salary is"+(((basic+0.20+0.80)*12)-(0.06+0.01)));
            System.Console.WriteLine("Take home Salary per month is"+(basic+0.20+0.80));
        }
        else if(basic <=20000 && basic>=10001)
        {
            System.Console.WriteLine("Annual Salary is"+(((basic+0.25+0.90)*12)-(0.06+0.01)));
            System.Console.WriteLine("Take home Salary per month is"+(basic+0.25+0.90));
        }
        else
        {
            System.Console.WriteLine("Annual Salary is"+(((basic+0.30+0.95)*12)-(0.06+0.01)));
            System.Console.WriteLine("Take home Salary per month is"+(basic+0.30+0.95));

        }
    }
}