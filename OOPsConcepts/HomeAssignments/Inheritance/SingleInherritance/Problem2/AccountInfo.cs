namespace Problem2
{
    public class AccountInfo:PersonInfo
    {
        public string AccountNumber { get; set; }
        public string Branch { get; set; }
        public string IfscCode { get; set; }
        public double Balance { get; set; }



        public AccountInfo(string name,string fatherName, long phone, DateTime dob ,string mailId,Gender gender,string accoundNumber,string branch,string ifsc,double balance):base( name, fatherName,phone,  dob , mailId, gender)
        {
            AccountNumber = accoundNumber;
            Branch = branch;
            IfscCode = ifsc;
            Balance = balance;

        }

        public void Deposit()
            {

            }
        
    }
}