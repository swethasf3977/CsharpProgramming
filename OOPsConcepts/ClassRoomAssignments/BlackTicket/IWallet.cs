namespace BlackTicket;
public interface IWallet
{
    static int _walletBalance;
    int WalletBalance { get{return _walletBalance;} }


    void RechargeBalance() {}
}