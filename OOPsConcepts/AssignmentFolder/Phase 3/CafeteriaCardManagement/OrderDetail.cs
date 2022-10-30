using System;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// used to select order status
    /// </summary>
    public enum Status{Default,Initiated,Ordered,Cancelled}
    public class OrderDetail
    {
        /// <summary>
        /// using this field is to create orderId by auto increment
        /// </summary>
        static int s_orderId = 1000;
        public string OrderId { get; set; }
        /// <summary>
        /// Used to get user id by user detail class
        /// </summary>
        /// <value></value>
        public string UserId { get; set; }
        /// <summary>
        /// used to get Date of order 
        /// </summary>
        /// <value></value>

        public  DateTime DateOfOrder { get; set; }
        /// <summary>
        /// used to get total amount which user ordered
        /// </summary>
        /// <value></value>
        public int TotalPrice { get; set; }
        /// <summary>
        /// used to get order status mentioned when the order is initated , booked and cancelled
        /// </summary>
        /// <value></value>
        public Status Status { get; set; }
        /// <summary>
        /// used to inialize the values using constructors
        /// </summary>
        /// <param name="userID">used to initialize the user Id </param>
        /// <param name="dateOfOrder">used to initialize the date of order when the order is booked</param>
        /// <param name="totalPrice">used to initialize the total amout of the product which was ordered by the user</param>
        /// <param name="bookingStatus">used to initialize the booking status which is ordered or cancelled</param>
        public OrderDetail(string userID,DateTime dateOfOrder,int totalPrice,Status bookingStatus)
        {
            s_orderId++;
            OrderId = "OID"+s_orderId;
            UserId = userID;
            DateOfOrder = dateOfOrder;
            TotalPrice = totalPrice;
            Status  =bookingStatus ;

        }
        /// <summary>
        /// used to get values in files 
        /// </summary>
        /// <param name="data">data is a name of parameter</param>
         public OrderDetail(string data)
        {
           string[] value = data.Split(",");
           s_orderId = int.Parse(value[0].Remove(0,2));
           OrderId = value[1];
           UserId = value[2];
           DateOfOrder = DateTime.Parse(value[3]);
           TotalPrice = int.Parse(value[4]);
           Status = Status.Parse<Status>(value[5],true);
          
        
       }
        
    }
}