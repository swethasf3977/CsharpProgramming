namespace OnlineGroceryShop
{
    public class ProductDetails
    {
        private static int s_productID=100;
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public double PricePerQuantity { get; set; }
        public ProductDetails(string productName,int quantityAvailable, double pricePerQuantity)
        {
            s_productID++;
            ProductID="PID"+s_productID;
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricePerQuantity;
        }
         public ProductDetails(string data)
        {
            string[] value = data.Split(","); 
            s_productID = int.Parse(value[0].Remove(0,2));
            ProductID = value[1];
            ProductName = value[2];
            QuantityAvailable = int.Parse(value[3]);
            PricePerQuantity = double.Parse(value[4]);
           
          
        }  
        
        
        
        
    }
}