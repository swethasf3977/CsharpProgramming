using System.IO;
namespace BlackTicket;
public class Files
{
    public static void Create()
    {
        if(!Directory.Exists("BlackTicket"))
        {
            Directory.CreateDirectory("BlackTicket");
            System.Console.WriteLine("Folder Created Successfully");
        }

        if(!File.Exists("BlackTicket/UserDetails"))
        {
            File.Create("BlackTicket/UserDetails.csv").Dispose();
        }
        if(!File.Exists("BlackTicket/BookingDetails"))
        {
            File.Create("BlackTicket/BookingDetails.csv").Dispose();
        }
        if(!File.Exists("BlackTicket/TheaterDetails"))
        {
            File.Create("BlackTicket/TheaterDetails.csv").Dispose();
        }
        if(!File.Exists("BlackTicket/MovieDetails"))
        {
            File.Create("BlackTicket/MovieDetails.csv").Dispose();
        }
        if(!File.Exists("BlackTicket/ScreeningDetails"))
        {
            File.Create("BlackTicket/ScreeningDetails.csv").Dispose();
        }
    }
    public static void ReadFile()
    {
            string[] user1 = File.ReadAllLines("BlackTicket/UserDetails.csv");
            foreach(string data in user1 )
            {
                UserDetails user = new UserDetails(data);
                Operations.userList.Add(user);
            }
            string[] user2 = File.ReadAllLines("BlackTicket/BookingDetails.csv");
            foreach(string data in user2 )
            {
                BookingDetails book = new BookingDetails(data);
                Operations.bookingList.Add(book);
            }
   
            string [] user3  =File.ReadAllLines("BlackTicket/TheaterDetails.csv");
            foreach(string data in user3)
            {
               TheaterDetails theater = new TheaterDetails(data);
                Operations.theaterList.Add(theater);
            }
            string [] user4  =File.ReadAllLines("BlackTicket/MovieDetails.csv");
            foreach(string data in user4)
            {
               MovieDetails movie = new MovieDetails(data);
                Operations.movieList.Add(movie);
            }
            string [] user5  =File.ReadAllLines("BlackTicket/ScreeningDetails.csv");
            foreach(string data in user5)
            {
               ScreeningDetails dept1 = new ScreeningDetails(data);
                Operations.screeningList.Add(dept1);
            }
        
    }

     public static void WriteToFiles()
        {
            string[] UserDetails = new string [Operations.userList.Count];
            for(int i = 0 ;i <Operations.userList.Count;i++)
            {
                UserDetails[i] = Operations.userList[i].UserID+","+Operations.userList[i].Name+","+ Operations.userList[i].Age+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].WalletBalance;
         
            }
            File.WriteAllLines("BlackTicket/UserDetails.csv",UserDetails);

            string[] BookingDetails = new string [Operations.bookingList.Count];
            for(int i = 0 ;i <Operations.bookingList.Count;i++)
            {
                BookingDetails[i] = Operations.bookingList[i].BookingId+","+Operations.bookingList[i].UserId+","+Operations.bookingList[i].MovieId+","+Operations.bookingList[i].TheaterId+","+Operations.bookingList[i].SeatCount+","+Operations.bookingList[i].TotalAmount+","+Operations.bookingList[i].BookingStatus;
          
            }
            File.WriteAllLines("BlackTicket/BookingDetails.csv",BookingDetails);


             string[]TheaterDetails = new string [Operations.theaterList.Count];
            for(int i = 0 ;i <Operations.theaterList.Count;i++)
            {
               TheaterDetails[i] = Operations.theaterList[i].TheaterId+","+Operations.theaterList[i].TheaterName+","+Operations.theaterList[i].TheaterLocation;
            }
            File.WriteAllLines("BlackTicket/TheaterDetails.csv",TheaterDetails);

            string[] MovieDetails = new string [Operations.movieList.Count];
            for(int i = 0 ;i <Operations.movieList.Count;i++)
            {
              MovieDetails[i] = Operations.movieList[i].MovieId+","+Operations.movieList[i].MovieName+","+Operations.movieList[i].Language;
            }
            File.WriteAllLines("BlackTicket/MovieDetails.csv",MovieDetails);


            string[] ScreeningDetails= new string [Operations.screeningList.Count];
            for(int i = 0 ;i <Operations.screeningList.Count;i++)
            {
                ScreeningDetails[i] = Operations.screeningList[i].MovieId+","+Operations.screeningList[i].TheaterId+","+Operations.screeningList[i].NumberOfSeatsAvailable+","+Operations.screeningList[i].TicketPrice;
            }
            File.WriteAllLines("BlackTicket/ScreeningDetails.csv",ScreeningDetails);
        }
  }


