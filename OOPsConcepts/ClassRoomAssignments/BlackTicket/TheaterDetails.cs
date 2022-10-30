namespace BlackTicket;
public class TheaterDetails
{
    static int s_theaterId = 300 ;
    public string TheaterId { get; set; }
    public string TheaterName { get; set; }
    public string TheaterLocation { get; set; }

    public TheaterDetails(string theaterName , string theaterLocation)
    {
        s_theaterId++;
        TheaterId = "TID" + s_theaterId;
        TheaterName = theaterName ;
        TheaterLocation = theaterLocation ;
    }
      public TheaterDetails(string data)
        {
            string[] value = data.Split(",");
            s_theaterId = int.Parse(value[0].Remove(0,2));  
            TheaterName = value[1];
            TheaterLocation = value[2];

        }
}