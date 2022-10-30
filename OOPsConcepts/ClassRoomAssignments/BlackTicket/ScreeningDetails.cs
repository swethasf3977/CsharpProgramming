namespace BlackTicket;
public class ScreeningDetails
{
    public string MovieId { get; set; }
    public string TheaterId { get; set; }
    public int NumberOfSeatsAvailable { get; set; }
    public int TicketPrice { get; set; }

    public ScreeningDetails(string movieId , string theaterId , int numberOfSeatsAvailable , int ticketPrice)
    {
        MovieId = movieId ;
        TheaterId = theaterId ;
        NumberOfSeatsAvailable = numberOfSeatsAvailable ;
        TicketPrice = ticketPrice ;
    }
     public ScreeningDetails(string data)
        {
            string[] value = data.Split(",");
            MovieId = value[0];
            TheaterId = value[1];
            NumberOfSeatsAvailable = int.Parse(value[2]);
            TicketPrice = int.Parse(value[3]);

        }
}