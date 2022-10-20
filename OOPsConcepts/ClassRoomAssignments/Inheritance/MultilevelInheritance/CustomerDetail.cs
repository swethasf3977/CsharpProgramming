namespace MultilevelInheritance
{
    public class CustomerDetail:PersonalDetails
    {
        private static int s_cusotmerID = 1000;
        public string CustomerID {get;set;}
        public double Balance { get; set; }


        public CustomerDetail(string aid,string name, string fatherName,Gender gender,long phone,double balance):base(aid, name, fatherName, gender, phone)
        {
            s_cusotmerID++;
            CustomerID = "CID"+s_cusotmerID;
            Balance = balance;

        }
        public void ShowDetail()
        {
            System.Console.WriteLine("Customer ID "+CustomerID);
            Show();
            System.Console.WriteLine("Balance "+Balance);

        }

    }
}