using System;
using System.Collections.Generic;

namespace LibraryManagement;

    public static class Operation
    {

       static List<UserDetail> userList = new List<UserDetail>();
       public static void MainMenu()
       {

            string choice = "yes";
            do
            {

            System.Console.WriteLine("Choose your Option \n 1.User Registration \n 2.User Login a \n 3.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {  
                    System.Console.WriteLine("Registration called");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login Called");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit Main Menu");
                    choice ="no";
                    break;
                 }
              }

            }while(choice =="yes");
            
            
            static void Registration()
            {
                    System.Console.WriteLine("Enter Your name");
                    string name = Console.ReadLine();
                    System.Console.WriteLine("Enter your mailId");
                    string mailId = Console.ReadLine();
                    System.Console.WriteLine("Enter Department : EEE,ECE,CSE");
                    Department department = Enum.Parse<Department>(Console.ReadLine(),true);
                    
                    System.Console.WriteLine("Enter Gender : Male ,Female,Transgender");
                    Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

                    System.Console.WriteLine("Enter your Mobile number");
                    double mobile = double.Parse(Console.ReadLine());
                    
               
               
                UserDetail user = new UserDetail(name,mailId,department,gender);

                userList.Add(user);
                System.Console.WriteLine("Your Registration id "+user.RegistrationId);
                System.Console.WriteLine("Registration Successfull");


            }
            
             static void Login()
            {
               
                System.Console.WriteLine("Enter registration Id");
                string registrationId = Console.ReadLine().ToUpper();
                int number=0;
                UserDetail user;

                foreach ( UserDetail registration in userList)
                {

                        if(registrationId == registration.RegistrationId)
                        {
                            System.Console.WriteLine("Valid User");
                            user = registration;

                            SubMenu( user);
                            number=1;

                        }
              
                }

                if(number==0)
                 {
                    System.Console.WriteLine("Invalid user");
                 }
            }
             static void SubMenu(UserDetail user)

            {    
                string choice ="yes";
                do
                {
                System.Console.WriteLine("Enter your choice \n 1.Borrow books \n 2.show history \n 3.Return Book \n 4.Exit");
                int choice1 = int.Parse(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                    {   BorrowBooks();
                        break;
                    }
                    case 2:
                    {
                        ShowHistory();
                        break;
                    }
                    case 3:
                    {
                        ReturnBook();
                        break;
                    }
                    case 4:
                    {  
                        choice = "no";
                        break;
                    }


                }
            }while(choice == "yes");
            
          }
          static void BorrowBooks(UserDetail user)
          {
            



          }

        
    }
  }
