namespace CafeteriaCardManagement
{
    public class CartItem
    {
        static int s_itemId = 100;
        public string ItemId { get; set; }
        public string OrderId { get; set; }
        public string FoodId { get; set; }
        public int OrderPrice { get; set; }
        public int OrderQuantity { get; set; }


        public CartItem(string orderId,string foodId, int orderPrice,int orderQuantity)
        {
            s_itemId++;
            ItemId = "IDI"+s_itemId;
            OrderId = orderId;
            FoodId = foodId;
            OrderId = orderId;
            OrderPrice = orderPrice;
            OrderQuantity = orderQuantity;
        }
         public CartItem(string data)
        {
           string[] value = data.Split(",");
           s_itemId = int.Parse(value[0].Remove(0,2));
           ItemId = value[1];
            OrderId = value[2];
            FoodId = value[3];
            OrderPrice = int.Parse(value[4]);
            OrderQuantity = int.Parse(value[5]);
        
       }
    }
}