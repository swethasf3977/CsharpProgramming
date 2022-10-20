using System;
namespace MethodPractice;
class Program 
{
    public static void Main(string[] args)
    {
        //method with argument with return type
        
       // int total = Addition(10,20);
      //  System.Console.WriteLine(total);
         System.Console.WriteLine(Addition(10,20));
        int Addition (int num1,int num2)
        {
            return num1+num2;
        }



        //methods with arguments without return type

        Subraction(20,10);

        void Subraction (int a,int b)
        {
            int difference;
            difference=a-b;
            System.Console.WriteLine("Difference"+difference);
        }
         //methods without arguments with return type
        
        
         int multiplication()
         {
            System.Console.WriteLine("Enter the Value1");
             int number1 = int.Parse(Console.ReadLine());
             System.Console.WriteLine("Enter the Value2");
             int number2 = int.Parse(Console.ReadLine());

             int product =number1*number2;
             return product;
         }
        int product1 = multiplication();
        System.Console.WriteLine("Product"+product1);


         //methods without argument without returntype
         Division();

         void Division()
         {
             System.Console.WriteLine("Enter the Value1");
             int number1 = int.Parse(Console.ReadLine());
             System.Console.WriteLine("Enter the Value2");
             int number2 = int.Parse(Console.ReadLine());
             System.Console.WriteLine("Division"+number1/number2);

          
         }




    }

}