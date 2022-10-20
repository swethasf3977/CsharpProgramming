using System;
namespace MethodAssignments;
class Program 
{
    public static void Main(string[] args)
    {  
        
         string condition ="";
    
        do {
            System.Console.WriteLine("Choose your option: \n 1.Addition \n 2.Subraction \n 3.Division \n 4.Multiplication");
            int choise = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter first  number");
            int num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter first  number");
            int num2 = int.Parse(Console.ReadLine());


            switch (choise)
            {

                case 1:
                {
                    
                    Addition( num1,num2);   
                    break;  
                    
                }
                
                case 2:
                {
                    
                    Subraction (num1, num2);   
                    break;  
                    
                }
                
                case 3:
                {
                    Division(num1, num2);   
                    break;  
                    
                }
                
                case 4:
                {
                    
                   Multiplication( num1,  num2) ;
                    break;  
                    
                }
                default:
                {
                    System.Console.WriteLine("invalid input");
                    break;
                }
            }
            
           
            void Addition(int num1, int num2)
            {
                System.Console.WriteLine("The sum value is"+(num1+num2));
            }
             

            void Subraction(int num1, int num2)
            {
                System.Console.WriteLine("Subtraction"+(num1-num2));
            }
             
              
              
            void Division(int num1 , int num2)
            {
                System.Console.WriteLine("Division"+(num1/num2));
            }
            
               
            void Multiplication(int num1, int num2)
            {
                System.Console.WriteLine("Multiplication"+(num1*num2));
            }
             


          System.Console.WriteLine("Enter Your Choice");
         condition = Console.ReadLine();
        
          } while(condition=="yes");


        }
    }
