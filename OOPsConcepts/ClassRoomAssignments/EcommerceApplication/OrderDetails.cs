using System;
using System.Collections.Generic;



namespace EcommerceApplication
{
    public enum OrderStatus {Default,Ordered,Cancelled}
    public class OrderDetails
    {
        private static int s_orderId =100;
        public string OrderId { get;  }
        public string CustomerId{ get; set; }
        public string ProductId{get;set;}
        public int Totalprice { get; set; }
        public DateTime DateOfOrder{get;set;}
        public int OrderQuantity { get; set; }
        public OrderStatus OrderStatus { get; set; }


        public OrderDetails(string customerID,string productId,int totalPrice,DateTime dateOfOrder,int orderQuantity,OrderStatus orderStatus)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            CustomerId =customerID;
            ProductId = productId;
            Totalprice = totalPrice;
            DateOfOrder = dateOfOrder;
            OrderQuantity =orderQuantity;
            OrderStatus = orderStatus;

        }
       
        
    }
}