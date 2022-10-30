using System;
namespace OnlineGroceryShop
{
    public class Registration:PersonalDetails,IBalance
    {
        private static int s_customerID=1000;
        public string CustomerID{get; set;}
        public double WalletBalance { get; set; }
        public Registration(string name,string fatherName, Gender gender, long mobile,DateTime dob,string mailID):base(name,fatherName,gender,mobile,dob,mailID) 
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
        }
        public Registration(string data):base(data)
        {
            string[] value = data.Split(",");
            s_customerID  = int.Parse(value[0].Remove(0,2));
            CustomerID = value[0];
            WalletBalance = int.Parse(value[1]);

        }

        public void ShowCustomerDetails()
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"CustomerID:{CustomerID}");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"FatherName: {FatherName}");
            System.Console.WriteLine($"Gender:{Gender}");
            System.Console.WriteLine($"Mobile Number:{Mobile}");
            System.Console.WriteLine($"Date Of Birth: {DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"MailID: {MailID}");
        }
        public void WalletRecharge()
        {
            System.Console.WriteLine($"Available Balance: {WalletBalance}");
            System.Console.WriteLine("Do you want to be recharged your wallet now(yes/No):");
            string recharge=Console.ReadLine().ToLower();
            if(recharge=="yes")
            {
                System.Console.WriteLine("how much amount do you want to be recharged:");
                double addrecharge=double.Parse(Console.ReadLine());
                WalletBalance=WalletBalance+addrecharge;
                System.Console.WriteLine($"Your available balance now: {WalletBalance}");
            }
            System.Console.WriteLine("Thank You!");
        }
        
        
    }
}