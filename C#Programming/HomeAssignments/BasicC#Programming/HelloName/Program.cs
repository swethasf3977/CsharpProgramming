using System;
namespace HelloName;

    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Hello");
            string hello = Console.ReadLine();
            System.Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            
            System.Console.WriteLine(  hello  + name);
            System.Console.WriteLine( "{0} {1}", hello ,  name);
            
            
        }
    
}