using System;
using System.Collections.Generic;
namespace PayRoll;
class Program 
{
    public static void Main(string[] args)
    {
        
      List<PayrollManagement> payrollList = new List<PayrollManagement>();
      string choice = "";
      do
          {
            System.Console.WriteLine("Enter Name");
            string name =Console.ReadLine();
           // System.Console.WriteLine("Enter DOB");
            Console.WriteLine(" Enter your date of birth dd/MM/yyyy format");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        
            System.Console.WriteLine("Enter mobile");
            float mob =float.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter gender");
            string gender =Console.ReadLine();

            PayrollManagement employee = new PayrollManagement(name,dob,mob,gender);
            payrollList.Add(employee);
            System.Console.WriteLine("Do you want to continue? (YES/NO)");
            choice = Console.ReadLine().ToUpper();
        

          }while(choice == "YES");


          foreach (PayrollManagement display in payrollList)
          {
            System.Console.WriteLine("The name is : "+display.Name);
           // System.Console.WriteLine("Date of Birth : "+display.DOB);
            System.Console.WriteLine("Mobile : "+display.Mobile);
            System.Console.WriteLine("Gender : "+display.Gender);
             Console.WriteLine(display.DOB.ToString("dd/MM/yyyy"));


          }






    }
}