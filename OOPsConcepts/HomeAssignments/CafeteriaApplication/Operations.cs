using System;
using System.Collections.Generic;

namespace CafeteriaApplication
{
    public class Operations
    {
        public static List<Cafeteria> usersList = new List<Cafeteria>();
        public static void MainMenu()
        {

        string condition ="yes";

       do
       {
       System.Console.WriteLine("Main Menu");
       System.Console.WriteLine("************");
       System.Console.WriteLine("Select option \n 1.Register \n 2.Login \n 3.Exit");
       int choice = int.Parse(Console.ReadLine());
       switch (choice)
       {

        case 1:
        {
            System.Console.WriteLine("Welcome to registration");
            Registration();
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

       public static void Registration()
       {
          // System.Console.WriteLine("I am in Registration");

            System.Console.WriteLine("Enter name");
            string name =Console.ReadLine();
            System.Console.WriteLine("Enter Mobile");
            double mobile = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Workshop no");
            int workno = int.Parse(Console.ReadLine()); 
            System.Console.WriteLine("Enter balance");
            int balance = int.Parse(Console.ReadLine());
            Cafeteria users = new Cafeteria(name,mobile,workno,balance);
            usersList.Add(users);          
           
       }
       public static void Login()
       {
        System.Console.WriteLine("Welcome to login");

        System.Console.WriteLine("Enter your userid");
        string userID = Console.ReadLine().ToUpper();
        foreach (Cafeteria user in usersList) 
        { 
            List<Cafeteria> usersList1 = new List<Cafeteria>();
            if (user.UserId == userID)
            {
                do 
                {
                System.Console.WriteLine("Pick Ur Food");
                System.Console.WriteLine("Food ID      Food     Price");
                System.Console.WriteLine("FID101      coffee      20");
                System.Console.WriteLine("FID102      Tea         15");
                System.Console.WriteLine("FID103      Buiscut     10");
                System.Console.WriteLine("FID104      Juice       50");
                System.Console.WriteLine("FID105      Puff        40");
                string choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "FID101":
                    {
                       System.Console.WriteLine("Your Food is Cofee. price is 20");
                       string food1 = Console.ReadLine();
                       food1.Add(usersList1);
                       System.Console.WriteLine("Your Food added");
                       break;
                    }
                    case "FID102":
                    {
                      System.Console.WriteLine("Your Food is Tea. price is 15");
                       string food2 = Console.ReadLine();
                      food2.Add(usersList1);
                       System.Console.WriteLine("Your Food added");
                       break;
                     }
                     case "FID103":
                    {
                      System.Console.WriteLine("Your Food is Buiscut. price is 10");
                       string food3 = Console.ReadLine();
                       food3.Add(usersList1);
                       System.Console.WriteLine("Your Food added");
                       break;
                     }
                     case "FID104":
                    {
                      System.Console.WriteLine("Your Food is Juice. price is 50");
                       string food4 = Console.ReadLine();
                       food4.Add(usersList1);
                       System.Console.WriteLine("Your Food added");
                       break;
                     }
                     case "FID105":
                    {
                      System.Console.WriteLine("Your Food is Puff. price is 40");
                       string food5 = Console.ReadLine();
                       food5.Add(usersList1);
                       System.Console.WriteLine("Your Food added");
                       break;
                     }
                     default:
                     {
                        System.Console.WriteLine("Invalid FoodId");
                        break;
                     }

                }
                System.Console.WriteLine("Do you want to continue (YES/NO)?");
                string choice2 = Console.ReadLine().ToUpper();
                }while(choice2 =="YES");



            }
        }


       }

    }
}