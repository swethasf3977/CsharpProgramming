using System;
using System.Collections.Generic;

namespace OnlineMedicalStore
{

    public enum OrderStatus{Default,Purchaced,Cancelled}
    public class OrderDetail
    {
        /// <summary>
        /// field is used to initialize the value through propety
        /// </summary>
        private static int s_orderId = 2000;
        /// <summary>
        /// used to track our order 
        /// </summary>
        /// <value></value>

        public  string OrderId { get;  }
        /// <summary>
        /// used to get orderid from order detail class
        /// </summary>
        /// <value></value>

        public string UserId { get; set; }
        /// <summary>
        /// used to get medicine id from medicine detail class
        /// </summary>
        /// <value></value>

        public string MedicineId { get; set; }
        /// <summary>
        /// used to get the count of medicines for purchacing
        /// </summary>
        /// <value></value>

        public int MedicineCount { get; set; }
        /// <summary>
        /// used to get the total price of the items which we ordered
        /// </summary>
        /// <value></value>
        public double TotalPrice{get;set;}
        /// <summary>
        /// used to get the date of order
        /// </summary>
        /// <value></value>

        public DateTime DateOfOrder { get; set; }
        /// <summary>
        /// used to get the status of item which we ordered
        /// </summary>
        /// <value></value>
        public OrderStatus OrderStatus { get; set; }
        
        /// <summary>
        /// used to inialize the values through parameters
        /// </summary>
        /// <param name="userId">used to initialize the user id from user detail class</param>
        /// <param name="medicineId">used to initialize the medicine id from medicine detail class</param>
        /// <param name="medicineCount">used to initialize medicine count from the medicine class through parameters</param>
        /// <param name="totalPrice">used to initialize the total price through parameter</param>
        /// <param name="dateOfOrder">used to initialize to date of order through the parameter</param>
        /// <param name="orderStatus">used to initialize to order status through the parameter</param>


        public OrderDetail(string userId , string medicineId,int medicineCount,double totalPrice,DateTime dateOfOrder,OrderStatus orderStatus )
        {
            s_orderId++;
            OrderId = "OID"+s_orderId;

            UserId = userId;
            MedicineId = medicineId;
            MedicineCount = medicineCount;
            TotalPrice = totalPrice;
            DateOfOrder = dateOfOrder;
            OrderStatus = orderStatus;


        }

        
    }
}