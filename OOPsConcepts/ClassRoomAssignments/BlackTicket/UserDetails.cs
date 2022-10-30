namespace BlackTicket;
public class UserDetails : PersonalDetails , IWallet
{
    static int s_userID = 1000 ;
    public string UserID { get; set; }
    public int WalletBalance { get; set; }

    public UserDetails(string name , int age , string phoneNumber , int walletBalance) : base(name , age ,phoneNumber)
    {
        s_userID++;
        UserID = "UID" +s_userID;
        WalletBalance = walletBalance;
    }
       public UserDetails(string data):base(data)
        {
            string[] value = data.Split(",");
            s_userID  = int.Parse(value[0].Remove(0,2));
            UserID = value[0];
            WalletBalance = int.Parse(value[1]);

        }

    public void RechargeBalance(int amount)
    {
        WalletBalance += amount;
    }
}