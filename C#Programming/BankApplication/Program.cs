using System;
using System.Collections.Generic;
namespace BankApplication;
class Program 

{
    public static void Main(string[] args)
    { 
      List<BankDetails> bankDetailList = new List<BankDetails>();
        string choise ="";

        do
        {
            System.Console.WriteLine("Enter name");
            string name =Console.ReadLine();
            System.Console.WriteLine("Enter father name");
            string fname = Console.ReadLine();

            System.Console.WriteLine("Enter gender options Male,Female,Transgender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter gender options FD,SD,SA");
            Account accountType = Enum.Parse<Account>(Console.ReadLine(),true);
            
            
            
            BankDetails user = new BankDetails(name,fname,gender,accountType);
            bankDetailList.Add(user);
            System.Console.WriteLine("This is your customer ID "+user.CustomerId);
            
            System.Console.WriteLine("Do you want to countinue?(YES?NO)");
            choise = Console.ReadLine().ToUpper();


        }while(choise == "YES");
        

        foreach (BankDetails user1 in bankDetailList)
        {
            System.Console.WriteLine("The name is : "+user1.Name);
            System.Console.WriteLine("Father name is : "+ user1.FatherName);
            System.Console.WriteLine("Gender : "+user1.Gender);
            System.Console.WriteLine("Account Type :"+user1.AccountType);

        
            
             System.Console.WriteLine("Enter your deposit amount");
              int depositAmount =int.Parse(Console.ReadLine());
          
          // System.Console.WriteLine("Your deposit amount "+user1.Balance);
         
            
              int totalAmount = user1.Deposit (depositAmount);
              System.Console.WriteLine("Your deposit ammount is "+ totalAmount);

          

            
              System.Console.WriteLine("Enter your widhraw amount");
              int withdrawAmount = int.Parse(Console.ReadLine());
             
           int totalbalance =  user1.withdraw(withdrawAmount);

           if(totalbalance > 0)
           {
           System.Console.WriteLine("Balance amount "+totalbalance);
           }
           else
           {
            System.Console.WriteLine("Insuffitiant balance");

           }

            


            }
          }
      
      
      
        }   
    

    
       