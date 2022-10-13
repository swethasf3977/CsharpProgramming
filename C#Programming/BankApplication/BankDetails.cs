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
        public int Balance { get; set; }



        public BankDetails(string name,string fname,Gender  gender,Account accountType)
        {

          s_customerId++;
          CustomerId = "HDFC" +s_customerId;
          Name =name;
          FatherName= fname;
          Gender =gender;
          AccountType = accountType;


        }
       public int Deposit (int depositAmount)
        {
        return Balance = Balance+depositAmount;
        }
        public int withdraw(int withdrawAmount)

        {
           return  Balance =Balance-withdrawAmount;

        }
    
        

    
    }
}