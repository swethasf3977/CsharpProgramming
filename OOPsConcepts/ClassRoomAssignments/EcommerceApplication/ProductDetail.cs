using System;

namespace EcommerceApplication
{
    public class ProductDetail
    {
        private static int s_productId =100;
        public string ProductId { get;  }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int ShippingDuration { get; set; }

        public ProductDetail(string productName, int price,int stock,int shippingDuration)
        {
            s_productId++;
            ProductId = "PID"+s_productId;
            ProductName = productName;
            Price =price;
            Stock = stock;
            ShippingDuration = shippingDuration;

        }






    }


}