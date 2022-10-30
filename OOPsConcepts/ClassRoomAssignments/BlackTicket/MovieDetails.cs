namespace BlackTicket;
public class MovieDetails
{
    static int s_movieId = 500 ;
    public string MovieId { get; set; }
    public string MovieName { get; set; }
    public string Language { get; set; }

    public MovieDetails(string movieName , string language)
    {
        s_movieId++;
        MovieId = "MID" + s_movieId ;
        MovieName = movieName ;
        Language = language;
    }
     public MovieDetails(string data)
        {
            string[] value = data.Split(",");
            s_movieId = int.Parse(value[0].Remove(0,2));  
            MovieId = value[1];
            MovieName = value[2];
            Language = value[3];

        }

}