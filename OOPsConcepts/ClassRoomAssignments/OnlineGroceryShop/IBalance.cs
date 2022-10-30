namespace OnlineGroceryShop
{
    public interface IBalance
    {
         double WalletBalance{get; set;}
         void WalletRecharge();
    }
}