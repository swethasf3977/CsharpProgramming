using System;
namespace BlackTicket;
public static partial class Operations
{
    static void TicketBooking()
    {
        string condition = "No" ;
        System.Console.WriteLine("\n***** Ticket Booking *****\n");

        int temp = 0 , flag = 0 , count = 0 ;

        //Traverse Theater Details And Display Theater details
        System.Console.WriteLine("| TheaterId | Theater Name | Theater Location |");
        foreach(TheaterDetails tempTheater in theaterList)
        {
            System.Console.WriteLine($"| {tempTheater.TheaterId} , {tempTheater.TheaterName} , {tempTheater.TheaterLocation} ");
        }
        System.Console.WriteLine("Enter the Theater Id: ");
        string theaterId = Console.ReadLine().ToUpper();
        
        foreach(TheaterDetails tempTheater in theaterList)
        {
            //Check Theater Id is Same As User Entered Theater Id
            if(tempTheater.TheaterId == theaterId)
            {
                temp = 1;
                System.Console.WriteLine("| Movie Id | Movie Name | Language |");
                //Display the Movie Details By Traversing Movie Details and Screening Details
                foreach(ScreeningDetails tempScreen in screeningList)
                {
                    if(tempTheater.TheaterId == tempScreen.TheaterId)
                    {
                        foreach(MovieDetails tempMovie in movieList)
                        {
                            if(tempMovie.MovieId == tempScreen.MovieId)
                            {
                                System.Console.WriteLine($"| {tempMovie.MovieId} , {tempMovie.MovieName} , {tempMovie.Language} ");
                            }
                        }
                    }
                }
                //Ask For Movie Id By Displaying Movie Details
                System.Console.WriteLine("Select the Movie By Movie Id: ");
                string movieId = Console.ReadLine().ToUpper();  
                foreach(MovieDetails tempMovie in movieList)
                {
                    if(tempMovie.MovieId == movieId)
                    {
                        do
                        {
                        flag = 1;
                        //Ask for Number Of Seats
                        System.Console.WriteLine("Enter the Number Of Seat To Book: ");
                        int numberOfSeat = int.Parse(Console.ReadLine());
                        //Check Wheather seat is Available or Not
                        foreach(ScreeningDetails tempScreen in screeningList)
                        {
                            if(tempMovie.MovieId == tempScreen.MovieId && tempScreen.TheaterId == tempTheater.TheaterId) 
                            {
                                if(tempScreen.NumberOfSeatsAvailable >= numberOfSeat)
                                {
                                    string check = "YES";
                                    count = 1;
                                    condition = "No";
                                    //Calculate Balance
                                    int price = tempScreen.TicketPrice * numberOfSeat ;
                                    double totalprice = price + (double) (price * 0.18) ;
                                    System.Console.WriteLine("Total Price is: "+totalprice);
                                    //Check Balance of the User
                                    do
                                    {
                                    if(totalprice <= logedinUser.WalletBalance)
                                    {
                                        //Deduct Amount
                                        logedinUser.WalletBalance -= price;
                                        //Deduct Seats
                                        tempScreen.NumberOfSeatsAvailable -= numberOfSeat ;
                                        BookingDetails book = new BookingDetails(logedinUser.UserID , tempMovie.MovieId , tempTheater.TheaterId , numberOfSeat , totalprice , BookingStatus.Booked);
                                        bookingList.Add(book);
                                        System.Console.WriteLine("Booking Successfull!!! Your Booking Id is: "+book.BookingId);
                                        System.Console.WriteLine(totalprice+" is Deducted From Your Account");
                                        check = "NO";
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Insufficient Balance to Book Your Ticket!!! Do You Wanna Rechange Your Wallet (Yes / No)");
                                        check = Console.ReadLine().ToUpper();
                                        RechargeWallet();
                                    }
                                    }while(check == "YES");
                                }
                                if(count == 0)
                                {
                                    System.Console.WriteLine($"Your Selected Seat : {numberOfSeat} is Not Available \nAvailable Seats is:  {tempScreen.NumberOfSeatsAvailable}");
                                    System.Console.WriteLine("Do You Wanna Reselect the Seats (Yes / No)");
                                    condition = Console.ReadLine().ToUpper();
                                }
                            }
                        }
                        }while(condition == "YES");
                    }
                }
            }
        }

        if(temp == 0)
        {
            System.Console.WriteLine("Invalid Theater Id!!! Please Enter the Valid ID ");
        }
        if(flag == 0)
        {
            System.Console.WriteLine("Invalid Movie Id!!! ");
        }  
    }

    static void TicketCancelling()
    {
        System.Console.WriteLine("\n***** Ticket Cancelling *****\n");

        string condition = "No";
        do
        {

        System.Console.WriteLine("| Booking Id | User ID | Movie ID | Theater Id | SeatCount | Total Amount | Booking Status |");

        foreach(BookingDetails booking in bookingList)
        {
            if(booking.BookingStatus == BookingStatus.Booked && booking.UserId == logedinUser.UserID)
            {
                System.Console.WriteLine($"{booking.BookingId} , {booking.UserId} , {booking.MovieId} , {booking.TheaterId} , {booking.SeatCount} , {booking.TotalAmount} , {booking.BookingStatus} ");
            }
        }
        System.Console.WriteLine("Enter the Booking Id You Want to Cancel");
        string bookingId = Console.ReadLine().ToUpper();
        int temp = 0;
        foreach(BookingDetails booking in bookingList)
        {
            if(booking.BookingId == bookingId && booking.BookingStatus == BookingStatus.Booked)
            {
                temp = 1;
                booking.BookingStatus = BookingStatus.Cancelled;
                System.Console.WriteLine("Booking Cancalled Successfully");
            }
        }
        if(temp == 0)
        {
            System.Console.WriteLine("Invalid Id !!! Do You Wanna Enter the Id Again:(yes / No) ");
            condition = Console.ReadLine().ToUpper();
        }
        }while(condition == "YES");
    }

    static void BookingHistory()
    {
        System.Console.WriteLine("\n***** Booking History *****\n");

        System.Console.WriteLine("| Booking Id | User ID | Movie ID | Theater Id | SeatCount | Total Amount | Booking Status |");

        foreach(BookingDetails booking in bookingList)
        {
            if(booking.UserId == logedinUser.UserID)
            {
                System.Console.WriteLine($"{booking.BookingId} , {booking.UserId} , {booking.MovieId} , {booking.TheaterId} , {booking.SeatCount} , {booking.TotalAmount} , {booking.BookingStatus} ");
            }
        }
    }

    static void RechargeWallet()
    {
        System.Console.WriteLine("\n***** Recharge Wallet *****\n");

        System.Console.WriteLine("Enter the Amount To Recharge");
        int amount = int.Parse(Console.ReadLine());
        logedinUser.RechargeBalance(amount);
        System.Console.WriteLine("Your Balance is: "+logedinUser.WalletBalance);
    }

}