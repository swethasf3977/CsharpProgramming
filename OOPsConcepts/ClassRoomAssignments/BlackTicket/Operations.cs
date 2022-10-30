using System;

namespace BlackTicket;
public delegate void EventManager();

public static partial class Operations
{
     public static event EventManager eventlink;
  
    public static List<BookingDetails> bookingList = new List<BookingDetails>();
    public static List<UserDetails> userList = new List<UserDetails>();
    public static List<TheaterDetails> theaterList = new List<TheaterDetails>();
    public static List<MovieDetails> movieList = new List<MovieDetails>();
    public static List<ScreeningDetails> screeningList = new List<ScreeningDetails>();
    public static UserDetails logedinUser;
    public static void MainMenu()
    {
        string condition = "YES";
        do
        {
            System.Console.WriteLine("\nWelcome to Black Ticket Booking\n");
            System.Console.WriteLine("Enter the Operation to do \n1.Registration \n2.Login \n3.Exit");
            int.TryParse(Console.ReadLine() , out int choice);
            switch(choice)
            {
                case 0:
                {
                    System.Console.WriteLine("Invalid Input!!!! \nPlease Enter the Valid Input From 1-3 ");
                    break;
                }
                case 1:
                {
                    System.Console.WriteLine("\n***** Registration Called *****\n");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("\n***** Login Called *****\n");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("\n***** Exiting Menu *****\n");
                    condition = "NO";
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid Input!!!! \nPlease Enter the Valid Input From 1-3 ");
                    break;
                }
            }
        } while (condition == "YES");
    }
    static void Registration()
    {
        System.Console.WriteLine("\n***** Welcome To Registration ******\n");

        System.Console.WriteLine("Enter the Name:");
        string name = Console.ReadLine();

        bool temp = true;
        int age = 0;
        do
        {    
            System.Console.WriteLine("Enter Your Age: ");
            temp = int.TryParse(Console.ReadLine() , out age);
            if(!temp)
            {
                System.Console.WriteLine("Please Enter the Age in Number Format (1 - 100)");
            }
        }while(!temp);

        System.Console.WriteLine("Enter Your Phone Number: ");
        string number = Console.ReadLine();
        
        System.Console.WriteLine("Enter Your Wallet Balance: ");
        int balance = int.Parse(Console.ReadLine());

        UserDetails user = new UserDetails(name , age , number , balance);
        userList.Add(user);

        System.Console.WriteLine("\nRegistration Successfull!!! Your Registration Id Is: "+user.UserID);

    }
    static void Login()
    {
        System.Console.WriteLine("\n***** Login *****\n");

        string condition = "YES";
        bool temp = true;
        do
        {
            System.Console.WriteLine("Enter the User Id: ");
            string userId = Console.ReadLine().ToUpper();
            foreach(UserDetails user in userList)
            {
                if(user.UserID == userId)
                {
                    System.Console.WriteLine("Login Successfull!!! Hai "+user.Name);
                    temp = false;
                    logedinUser=user;
                    SubMenu();
                }
            }
            if(temp)
            {
                System.Console.WriteLine("Invalid Id");
                System.Console.WriteLine("Do You Wanna Enter the Id Again:(YES / No) ");
                condition = Console.ReadLine().ToUpper();
            }
        }while(condition == "YES" && temp );
    }

    static void SubMenu()
    {
        System.Console.WriteLine("\n***** Welcome to Sub Menu ***** \n");
        string condition = "YES";
        do
        {
            System.Console.WriteLine("\nWelcome to Black Ticket Booking\n");
            System.Console.WriteLine("Enter the Operation to do \n1.Ticket Booking \n2.Ticket Cancelling \n3.Booking History \n4.Wallet Recharge \n5.Exit");
            int.TryParse(Console.ReadLine() , out int choice);
            switch(choice)
            {
                case 0:
                {
                    System.Console.WriteLine("Invalid Input!!!! \nPlease Enter the Valid Input From 1-3 ");
                    break;
                }
                case 1:
                {
                    System.Console.WriteLine("\n***** Ticket Booking Called *****\n");
                    TicketBooking();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("\n***** Ticket Cancelling Called *****\n");
                    TicketCancelling();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("\n***** Booking History Called *****\n");
                    BookingHistory();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("\n***** Wallet Recharge Called *****\n");
                    RechargeWallet();
                    break;
                }
                case 5:
                {
                    condition = "NO";
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid Input!!!! \nPlease Enter the Valid Input From 1-3 ");
                    break;
                }
            }
        } while (condition == "YES");
    }
           private static void Subscribe()
                {
                    eventlink += new EventManager(Files.Create);
                    eventlink += new EventManager(Files.ReadFile);
                    eventlink += new EventManager(MainMenu);
                    eventlink +=new EventManager(Files.WriteToFiles);
                }

                public static void Starter()
                {
                    Subscribe();
                    eventlink();
                }


    public static void DefaultDetails()
    {
        //Default Book Details
        bookingList.Add(new BookingDetails("UID1001" , "MID501" , "TID301" , 1 , 200 , BookingStatus.Booked));
        bookingList.Add(new BookingDetails("UID1001" , "MID504" , "TID302" , 1 , 400 , BookingStatus.Booked));
        bookingList.Add(new BookingDetails("UID1002" , "MID505" , "TID302" , 1 , 300 , BookingStatus.Booked));

        //Default User Details
        userList.Add(new UserDetails("Ravi" , 30 , "98764321123" , 1000 ));
        userList.Add(new UserDetails("Baskaran" , 30 , "878456789" , 2000));

        //Default Theater Details
        theaterList.Add(new TheaterDetails("Inox" , "AnnaNagar"));
        theaterList.Add(new TheaterDetails("Ega Theater" , "Chetpet" ));
        theaterList.Add(new TheaterDetails("Kamala" , "Vadapalani" ));

        //Default Movie List Details
        movieList.Add(new MovieDetails("Bagubali 2" , "Telugu"));
        movieList.Add(new MovieDetails("Ponniyin Selven" , "Tamil"));
        movieList.Add(new MovieDetails("Cobra" , "Tamil"));
        movieList.Add(new MovieDetails("Vikram" , "Hindi(Dubbed)" ));
        movieList.Add(new MovieDetails("Vikram" , "Tamil"));
        movieList.Add(new MovieDetails("Beast" , "English"));

        //Default Screening Details
        screeningList.Add(new ScreeningDetails("MID501" , "TID301" , 5 , 200));
        screeningList.Add(new ScreeningDetails("MID502" , "TID301" , 2 , 300));
        screeningList.Add(new ScreeningDetails("MID506" , "TID301" , 1 , 50));
        screeningList.Add(new ScreeningDetails("MID501" , "TID302" , 11 , 400));
        screeningList.Add(new ScreeningDetails("MID502" , "TID302" , 20 , 300));
        screeningList.Add(new ScreeningDetails("MID504" , "TID302" , 2 , 500));
        screeningList.Add(new ScreeningDetails("MID505" , "TID303" , 11 , 100));
        screeningList.Add(new ScreeningDetails("MID502" , "TID303" , 20 , 200));
        screeningList.Add(new ScreeningDetails("MID504" , "TID303" , 2 , 350));
    }
}