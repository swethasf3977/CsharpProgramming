using System;
namespace OnlineGroceryShop
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID=3000;
        public string BookingID { get; set; }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        
        public DateTime DateOfBooking { get; set; }
        
        public BookingStatus Status { get; set; }
        public BookingDetails(string customerID,double totalPrice,DateTime dateOfBooking,BookingStatus status)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            Status=status;
        }     

         public BookingDetails(string data)
        {
            string[] value = data.Split(","); 
            s_bookingID = int.Parse(value[0].Remove(0,2));
            BookingID = value[1];
            CustomerID = value[2];
            TotalPrice =double.Parse(value[3]);
            DateOfBooking = DateTime.Parse(value[4]);
            Status = BookingStatus.Parse<BookingStatus>(value[5],true);
           
          
        }               
        
    }
}