namespace OnlineGroceryShop
{
    public class OrderDetails
    {
        private static int s_orderID=200;
        public string OrderID { get; set; }
        public string BookingID { get; set; }
        public string ProductID { get; set; }
        public int ProductCount { get; set; }
        
        public double PriceOfOrder { get; set; }
        public OrderDetails(string bookingID,string productID,int productCount,double priceOfOrder )
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            BookingID=bookingID;
            ProductID=productID;
            ProductCount=productCount;
            PriceOfOrder=priceOfOrder;
        } 
         public OrderDetails(string data)
        {
            string[] value = data.Split(","); 
            s_orderID = int.Parse(value[0].Remove(0,2));
            OrderID = value[1];
            BookingID = value[2];
            ProductID = value[3];
            ProductCount = int.Parse(value[4]);
            PriceOfOrder = double.Parse(value[5]);     
          
        }  
        
    }
}