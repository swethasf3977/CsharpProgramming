namespace BlackTicket;
public enum BookingStatus{ Default , Booked , Cancelled }
public class BookingDetails
{
    static int s_bookingId = 7000 ;
    public string BookingId { get; set; }
    public string UserId { get; set; }
    public string MovieId { get; set; }
    public string TheaterId { get; set; }
    public int SeatCount { get; set; }
    public double TotalAmount { get; set; }
    public BookingStatus BookingStatus { get; set; }

    public BookingDetails(string userID , string movieId , string theaterId , int seatCount , double totalAmount , BookingStatus bookingStatus)
    {
        s_bookingId++;
        BookingId = "BID" + s_bookingId;
        UserId = userID ;
        MovieId = movieId;
        TheaterId = theaterId ;
        SeatCount = seatCount;
        TotalAmount = totalAmount;
        BookingStatus = bookingStatus ;
    }
      public BookingDetails(string data)
        {
            string[] value = data.Split(",");
            s_bookingId= int.Parse(value[0].Remove(0,2));
            BookingId = value[1];
            UserId = value[2];
            MovieId = value[3];
            TheaterId = value[4];
            SeatCount = int.Parse(value[5]);
            TotalAmount = double.Parse(value[6]);
            BookingStatus = BookingStatus.Parse<BookingStatus>(value[7],true);

        }
}