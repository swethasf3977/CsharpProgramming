using System;
using System.Collections.Generic;
namespace StudentAdmission
{
    public static class Operations
    {

        public static List<StudentDetails> studentList = new List<StudentDetails>();
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
            System.Console.WriteLine("Registration Called");
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
            System.Console.WriteLine("Enter father name");
            string fatherName = Console.ReadLine();

            System.Console.WriteLine("Enter gender options Male,Female,Transgender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your age");
            int age  = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter mail");
            string mail =Console.ReadLine();
            System.Console.WriteLine("Enter pysics mark");
            int physics = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter chemistry mark");
            int chemistry = int.Parse(Console.ReadLine());
            

            System.Console.WriteLine("Enter maths mark");
            int maths = int.Parse(Console.ReadLine()); 
            StudentDetails student = new StudentDetails(name,fatherName,gender,age,mail,physics,chemistry,maths);
            studentList.Add(student);          
           
       }
       public static void Login()
       {
        System.Console.WriteLine("I am in Login");
       }


    }
}