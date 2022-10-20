using System;
using System.Collections.Generic;


namespace BankApplication
{
    public static class Operation
    {

        static List<BankDetails> bankDetailList = new List<BankDetails>();
      

        public static void MainMenu()
        {
            string condition ="yes";

       do
       {
       System.Console.WriteLine("Main Menu");
       System.Console.WriteLine("Select option \n 1.Register \n 2.Login \n 3.Exit");
       int choice = int.Parse(Console.ReadLine());
       switch (choice)
       {

        case 1:
        {
            System.Console.WriteLine("Welcome to registration");
            Registration();
            System.Console.WriteLine("Account Created successfully");
            MainMenu();
          break;
        }
        case 2:
        {
            System.Console.WriteLine("Login called");

            Login();
            
            break;
        }
        case 3:
        {
            condition ="No";
            break;
        }
       

       }  }while (condition == "yes");


        }
  
       
        static void Registration()
         {
            string choice ="";
         do

         {
          // System.Console.WriteLine("I am in Registration");
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
            System.Console.WriteLine("Do you want to continue");
            choice = Console.ReadLine().ToLower();
            
          }while(choice=="yes");
         }

         
         
          static  void Login()
          {
            SubMenu();
          }
          static void SubMenu()
          {
            System.Console.WriteLine("Enter option \n 1.Deposit \n 2.Withraw \n 3.ShowDetails \n 4.Exit");
            int choice1 = int.Parse(Console.ReadLine());
            foreach(BankDetails user in bankDetailList)
            {
              switch(choice1)
              {
                case 1:
                {
                    System.Console.WriteLine("Enter deposit amount ");

                    double depositAmount = double.Parse(Console.ReadLine());
                    double totalAmount = user.Deposit (depositAmount);
                     System.Console.WriteLine("Your deposit ammount is "+ totalAmount);
                     SubMenu();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Enter widraw amount");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    double totalAmount = user.withdraw(withdrawAmount);
                    if(totalAmount>0)
                    {
                        System.Console.WriteLine("total balance"+totalAmount);

                    }
                    else
                    {
                        System.Console.WriteLine("Insufficient amount");
                    }
                    break;


                     }
               case 3:
                        {
                            user.ShowDetails(user);
                            SubMenu();
                            break;
                            
                        }
                case 4:
                        {
                            MainMenu();
                            break;
                        }



                }


                
              }


            }


          }
}







                    



          
        



     
