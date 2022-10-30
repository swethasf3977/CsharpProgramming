namespace CafeteriaCardManagement
{
    public interface IBalance
    {
      static int _walletBalance;
      int WalletBalance { get{return _walletBalance;} }


      void WalletRecharge(double amount) 
      {

      }
    }
}