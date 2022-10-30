namespace CafeteriaCardManagement
{
    /// <summary>
    /// used to get user details by inherits personal detail class and balance interface
    /// </summary>
    public class UserDetail:PersonalDetail,IBalance
    {
    /// <summary>
    /// used to get user Id by auto increment
    /// </summary>
     static int s_userID = 1000 ;
    public string UserID { get; set; }
    /// <summary>
    /// used to get wallet balance by the user
    /// </summary>
    /// <value></value>
    public int WalletBalance { get; set; }
    /// <summary>
    /// used to initialize the values in constructor
    /// </summary>
    /// <param name="name">used to initialize the name of the user</param>
    /// <param name="fatherName">used to initialize the users father name</param>
    /// <param name="gender">used to initialize the gender of the user</param>
    /// <param name="mobile">used to initalize the user mobile number</param>
    /// <param name="mailId">used to initialize the user mailid</param>
    /// <param name="walletBalance">used to initialize the walletBalance of the user</param>
    /// <returns></returns>

    public UserDetail(string name , string fatherName, Gender gender,string mobile,string mailId, int walletBalance) : base(name,fatherName,gender,mobile,mailId)
    {
        s_userID++;
        UserID = "SF" +s_userID;
        WalletBalance = walletBalance;

    }
    /// <summary>
    /// used to get 
    /// </summary>
    /// <param name="data"></param>

    public UserDetail(string data):base(data)
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
}