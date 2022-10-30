using System;

namespace EcommerceApplication
{
    public class CustomerDetail
    {
        private static int s_customerId = 1000;
        public string CustomerId { get;  }
        public string  Name { get; set; }
        public string  City { get; set; }
        public double Mobile { get; set; }  
        public string MailId { get; set; }
        public double WalletBalance { get; set; }      


        public CustomerDetail(string name,string city,double mobile,string mailId,double balance)
        {
            s_customerId++;
            CustomerId = "CID"+ s_customerId;

            Name = name;
            City = city;
            Mobile = mobile;
            MailId = mailId;
            WalletBalance= balance;


        }
        
    }
}