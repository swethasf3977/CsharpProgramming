using System;

namespace BankApplication
{


  public enum Gender {Default,Male,Female,Transgender}
  public enum Account {FD,RD,SA}
    public class BankDetails
    {
        private static int s_customerId = 1000;

        public string CustomerId {get;}
        public string Name { get; set; }
        public  string FatherName { get; set; }
        public Gender Gender { get; set; }
        public Account AccountType { get; set; }
        public double Balance { get; set; }



        public BankDetails(string name,string fname,Gender  gender,Account accountType)
        {

          s_customerId++;
          CustomerId = "HDFC" +s_customerId;
          Name =name;
          FatherName= fname;
          Gender =gender;
          AccountType = accountType;


        }
       public double Deposit (double amount1)
        {
             Balance = Balance+amount1;
             return Balance;
        }
        public double withdraw(double amount2)

        {
          if (Balance>=amount2)
          {
            Balance =Balance-amount2;
            return Balance;
          }
          else 
          {
            return Balance;

          }

        }
         public   void ShowDetails(BankDetails user)
        {

            System.Console.WriteLine("Customer ID"+ user.CustomerId);
            System.Console.WriteLine("The name is : "+user.Name);
            System.Console.WriteLine("Father name is : "+ user.FatherName);
            System.Console.WriteLine("Gender : "+user.Gender);
            System.Console.WriteLine("Account Type :"+user.AccountType);

        
        }
    
    
    }
}