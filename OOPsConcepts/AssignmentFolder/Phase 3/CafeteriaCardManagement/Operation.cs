using System;

namespace CafeteriaCardManagement
{
    public delegate void EventManager();
    public static class Operation

    {
       public static event EventManager eventlink;
       public static List<UserDetail> userList  = new List<UserDetail>();
       public static List<FoodDetail> foodList = new List<FoodDetail>();
       public static List<CartItem> cardList = new List<CartItem>();
       public static   List<OrderDetail> orderList = new List<OrderDetail>();

       public static UserDetail logedinUser;

        public static void MainMenu()
        {
            // creating main menu 
            string mainMenuChoice="yes";
            do
            {
                System.Console.WriteLine("Enter your choice: \n 1.CustomerRegistration \n 2.Login \n 3.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                       
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                      
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit from the Main menu");
                        mainMenuChoice="no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid choice");
                        break;
                    }
                }
            }while(mainMenuChoice=="yes");

        }

        //creating registration
        static void UserRegistration()
        {
            System.Console.WriteLine("Registration called !");
            System.Console.WriteLine("********************");
            System.Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your Father name");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter your mobille number");
            string mobile = Console.ReadLine();
            System.Console.WriteLine("Enter your Mail Id");
            string mailId  =Console.ReadLine();

            System.Console.WriteLine("Enter your gender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your balance");
             int walletBalance = int.Parse(Console.ReadLine());
             UserDetail user = new UserDetail(name,fatherName,gender,mobile,mailId,walletBalance);
             userList.Add(user);
             System.Console.WriteLine("Registration successfull !! your user Id is "+user.UserID);
            
        }
         static void Login()
        {

        string condition = "YES";
        bool temp = true;
        do
        {
            System.Console.WriteLine("Enter the User Id: ");
            string userId = Console.ReadLine().ToUpper();
            foreach(UserDetail user in userList)
            {
                if(user.UserID == userId)
                {
                    System.Console.WriteLine("Login Successfull!!! Hi "+user.Name);
                    temp = false;
                    logedinUser=user;
                    SubMenu();
                }
            }
            if(temp)
            {
                System.Console.WriteLine("Invalid Id");
                System.Console.WriteLine("Do You Want enter again:(YES / No) ");
                condition = Console.ReadLine().ToUpper();
            }
        }while(condition == "YES" && temp );
    }
   
    // calling submenu
    static void SubMenu()
    {
        System.Console.WriteLine("Enter your choice : \n 1.Show my profile \n 2.Food Order \n 3.Cancel Order \n 4.Order History \n 5.Wallet Recharge \n 6.Exit");
        int choice = int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {   
                ShowMyProfile();
                break;
            }
            case 2:
            {   
                FoodOrder();
                break;
            }
            case 3:
            {
                CancelOrder();
                break;
            }
            case 4:
            {
                OrderHistory();
                break;
            }
            case 5:
            {
                WalletRecharge();
                break;
            }
            case 6:
            {
                break;
            }
        }

    }
    static void ShowMyProfile()
    {
        foreach(UserDetail tempUser in userList)
        {
            if(logedinUser.UserID == tempUser.UserID)
            {
                System.Console.WriteLine("Your user Id "+tempUser.UserID);
                System.Console.WriteLine("Your Name "+tempUser.Name);
                System.Console.WriteLine("Your Father Name "+tempUser.FatheName);
                System.Console.WriteLine("Your Gender "+tempUser.Gender);
                System.Console.WriteLine("Your Mail id "+tempUser.MailId);
                System.Console.WriteLine("Your Mobile Number "+tempUser.Mobile);
                System.Console.WriteLine(" Your balance "+tempUser.WalletBalance);
            }
        }

    }

    /*Create an Order object with current UserID, Order date as current DateTime, total price
as 0, Order status as “Initiated”.
 Ask the user to pick a product using FoodID, quantity required and calculate price of
food.
 If the food and quantity available, reduce the quantity from the food object’s
“AvailableQuantity” then create CartItems object using the available data.
 Add that object it to local CartItemsList to add it to cart wish list.
 Ask the user whether he want to pick another product.
 If “Yes” then repeat from step “2”.
 Repeat the process until the user enters “No”.
 Ask the user whether he confirm the wish list to purchase. If he says “No” then traverse
the local CartItemList and get the Items one by one and reverse the quantity to the
FoodItem’s objects.
 If he says “Yes” then, Calculate the total price of the food items selected using the local
CartItemList information and check the balance from the user details whether it has
sufficient balance to purchase.
If he has enough balance, then deduct the respective amount from the user’s balance.
 Append the local CartItemList to global CartItemList.
. Modify Order object created at step 1’s total price as total OrderPrice and OrderStatus
as “Ordered”.*/
   
    static void FoodOrder()
    {
        foreach(FoodDetail tempFood in foodList)
        {
            System.Console.WriteLine("Food Id "+tempFood.FoodId);
            System.Console.WriteLine("Food Name "+tempFood.FoodName);
            System.Console.WriteLine("Food price "+tempFood.FoodPrice);
            System.Console.WriteLine("Available Quantity "+tempFood.AvailableQuantity);

        OrderDetail order = new OrderDetail(logedinUser.UserID,DateTime.Now,0,Status.Initiated);
        orderList.Add(order);
        System.Console.WriteLine("Enter your food id ");
        string foodID = Console.ReadLine();
        System.Console.WriteLine("Enter the Quantity of the food ");
        double count = int.Parse(Console.ReadLine());
        //traversing the food detail for order
        
            if(count <= tempFood.AvailableQuantity)
            {
                System.Console.WriteLine("Your food is available!!");
                double TotalAmount = count * tempFood.FoodPrice;
                if(TotalAmount <= logedinUser.WalletBalance)
                {
                    System.Console.WriteLine("You have suffitient balance .....");
                    System.Console.WriteLine("Your order is placed successfully!!");

                }
                else
                {
                    System.Console.WriteLine("You have insuffitient Balance .....Please Recharge");
                }
            }

        }
    
    }
    static void CancelOrder()
    {
        System.Console.WriteLine("Cancell Order Called .....");

        string condition = "No";
        do
        {
         // showing order history
        foreach(OrderDetail tempOrder in orderList)
        {
            if(tempOrder.Status == Status.Ordered && tempOrder.UserId == logedinUser.UserID)
            {
                  System.Console.WriteLine("Order Id "+tempOrder.OrderId);
                  System.Console.WriteLine("User Id "+tempOrder.UserId);
                  System.Console.WriteLine("Date of Ordered "+tempOrder.DateOfOrder);
                  System.Console.WriteLine("Total Price "+tempOrder.TotalPrice);
                  System.Console.WriteLine("Order status "+tempOrder.Status);
            }
        }

        // asking order id to cancell
        System.Console.WriteLine("Enter the Order Id You Want to Cancel");
        string orderID = Console.ReadLine().ToUpper();
        int temp = 0;
        foreach(OrderDetail tempOrder in orderList)
        {
            if(tempOrder.OrderId == orderID && tempOrder.Status == Status.Ordered)
            {
                temp = 1;
                tempOrder.Status = Status.Cancelled;
                System.Console.WriteLine("Order Cancalled Successfully");
            }
        }
        if(temp == 0)
        {
            System.Console.WriteLine("Invalid Id !!! Do You Wanna Enter the Id Again:(yes / No) ");
            condition = Console.ReadLine().ToUpper();
        }
        }while(condition == "YES");
    }
    static void OrderHistory()
    {
        System.Console.WriteLine("Order History called ......");

        foreach(OrderDetail tempOrder in orderList)
        {
            if(tempOrder.UserId == logedinUser.UserID)
            {
                  System.Console.WriteLine("Order Id "+tempOrder.OrderId);
                  System.Console.WriteLine("User Id "+tempOrder.UserId);
                  System.Console.WriteLine("Date of Ordered "+tempOrder.DateOfOrder);
                  System.Console.WriteLine("Total Price "+tempOrder.TotalPrice);
                  System.Console.WriteLine("Order status "+tempOrder.Status);
                
            }
        }
    }

    static void WalletRecharge()
    {
        System.Console.WriteLine("Recharge wallet called....");
        System.Console.WriteLine("Enter the Amount To Recharge");
        int amount = int.Parse(Console.ReadLine());
        logedinUser.RechargeBalance(amount);
        System.Console.WriteLine("Your Balance is: "+logedinUser.WalletBalance);
    }

    public static void DefaultData()
    {
         UserDetail user1 = new UserDetail("Ravichandran","Ettaparajan",Gender.Male,"88585994","ravi@mail",400);
         UserDetail user2 = new UserDetail("Baskaran","Sethurajan",Gender.Male,"857589494","baskaran@mail",500);
         userList.Add(user1);
         userList.Add(user2); 
                 FoodDetail food1 = new FoodDetail("Coffee",20,100);
                 FoodDetail food2 = new FoodDetail("Tea",15,100);
                 FoodDetail food3 = new FoodDetail("Biscuit",10,100);
                 FoodDetail food4 = new FoodDetail("Juice",50,100);  
                 FoodDetail food5 = new FoodDetail("Puff",40,100);   
                 FoodDetail food6 = new FoodDetail("Milk",10,100);
                 FoodDetail food7 = new FoodDetail("Popcorn",20,10);
                  foodList.Add(food1);
                  foodList.Add(food1);
                  foodList.Add(food1);
                  foodList.Add(food1);
                  foodList.Add(food1);
                  foodList.Add(food1);
                  foodList.Add(food1);
           OrderDetail order1 = new OrderDetail("SF1001",new DateTime(2000,06,15),70,Status.Ordered);
           OrderDetail order2 = new OrderDetail("SF1002",new DateTime(2022,06,15),100,Status.Ordered);
           orderList.Add(order1);
           orderList.Add(order2);
           CartItem card1 = new CartItem("OID1001","FID101",20,1);
           CartItem card2 = new CartItem("OID1001","FID103",10,1);
           CartItem card3 = new CartItem("OID1001","FID105",40,1);
           CartItem card4 = new CartItem("OID1002","FID103",10,1);
           CartItem card5 = new CartItem("OID1002","FID104",50,1);
           CartItem card6 = new CartItem("OID1002","FID105",40,1);
           cardList.Add(card1);
           cardList.Add(card2);
           cardList.Add(card3);
           cardList.Add(card4);
           cardList.Add(card5);
           cardList.Add(card6);       

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

}
}