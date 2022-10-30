using System;
using System.Collections.Generic;
namespace OnlineGroceryShop
{
    public delegate void EventManager();
    public static class Operations
    {
        public static event EventManager eventlink;
        public static Registration currentRegister=null;
        public static List<Registration> registerList=new List<Registration>();
        public static List<ProductDetails> productList=new List<ProductDetails>();
        public static List<BookingDetails> bookingList=new List<BookingDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static List<OrderDetails> tempOrderList=new List<OrderDetails>();

        public static void Mainmenu()
        {
            string mainMenuChoice="yes";
            do
            {
                System.Console.WriteLine("Enter your choice\n\t1.CustomerRegistration\n\t2.Login and purchase\n\t3.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("registartion Called....");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("login called...");
                        Login();
                        break;
                    }
                    case 3:
                    {
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
        public static void Submenu()
        {
            string submenuChoice="yes";
            do
            {
                System.Console.WriteLine("Enter Your Choice \n\t1.Show Customer Details\n\t2.Show Product Details\n\t3.Wallet Recharge\n\t4.Take Order\n\t5.Modify Order Quantity\n\t6.Cancel Order\n\t7.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        
                        System.Console.WriteLine("Customer Details....");
                        CustomerDetails();
                        break;
                    }
                    case 2:
                    {
                        
                        System.Console.WriteLine("Product Details....");
                        ShowProductDetails();

                        break;
                    }
                    case 3:
                    {
                        
                        System.Console.WriteLine("Recharged...");
                        WalletRecharge();
                        break;
                    }
                    case 4:
                    {
                        
                        System.Console.WriteLine("Take Order....");
                        TakeOrder();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Modify Quantity...");
                        ModifyOrderQuantity();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Cancel Order....");
                        CancelOrder();
                        break;
                    }
                    case 7:
                    {
                        System.Console.WriteLine("Exited......");
                        submenuChoice="no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid Choice");
                        break;
                    }
                }
            }while(submenuChoice=="yes");
        }
        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter Your Name :");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter Your Father Name :");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your Gender:");
            Gender gender =Enum.Parse<Gender>(Console.ReadLine());
            System.Console.WriteLine("Enter your mobile number :");
            long mobile=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your DOB in dd/MM/yyyy format:");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy"),null);
            System.Console.WriteLine("Enter your Mail ID :");
            string mailID=Console.ReadLine();
            Registration customer=new Registration(name,fatherName,gender,mobile,dob,mailID);
            registerList.Add(customer);
            System.Console.WriteLine($"Your registration completed successfully\nYour Customer ID is :{customer.CustomerID}");
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Customer ID:");
            string customerID=Console.ReadLine().ToUpper();
            int temp=0;
            foreach(Registration customer in registerList)
            {
                if(customerID==customer.CustomerID)
                {
                    System.Console.WriteLine("Login Successfully...");
                    temp=1;
                    currentRegister=customer;
                    Submenu();
                    break;
                }
            }
            if(temp==0)
            {
                System.Console.WriteLine("Invalid Customer ID");
            }
        }
        public static void DefaultData()
        {
            Registration customer1=new Registration("Ravi","Ettaparajan",Gender.Male,9988776655,new DateTime(1999,11,11),"ravi@gmail.com");
            registerList.Add(customer1);
            Registration customer2=new Registration("Baskaran","Sethurajan",Gender.Male,8899775566,new DateTime(1999,11,11),"baskaran@gmail.com");
            registerList.Add(customer2);

           
            ProductDetails product1=new ProductDetails("Sugar",20,40);
            productList.Add(product1);
            ProductDetails product2=new ProductDetails("Rice",100,50);
            productList.Add(product2);
            ProductDetails product3=new ProductDetails("Milk",10,40);
            productList.Add(product3);
            ProductDetails product4=new ProductDetails("Coffee",10,10);
            productList.Add(product4);
            ProductDetails product5=new ProductDetails("Tea",10,10);
            productList.Add(product5);
            ProductDetails product6=new ProductDetails("MalasaPowder",10,20);
            productList.Add(product6);
            ProductDetails product7=new ProductDetails("Salt",10,10);
            productList.Add(product7);
            ProductDetails product8=new ProductDetails("Turmeric Powder",10,25);
            productList.Add(product8);
            ProductDetails product9=new ProductDetails("Chilli Powder",15,20);
            productList.Add(product9);
            ProductDetails product10=new ProductDetails("Groundnut Oil",10,140);
            productList.Add(product10);

            BookingDetails booking1=new BookingDetails(customer1.CustomerID,220,new DateTime(2022,07,26),BookingStatus.Booked);
            bookingList.Add(booking1);
            BookingDetails booking2=new BookingDetails(customer2.CustomerID,400,new DateTime(2022,07,26),BookingStatus.Booked);
            bookingList.Add(booking2);
            BookingDetails booking3=new BookingDetails(customer1.CustomerID,280,new DateTime(2022,07,26),BookingStatus.Cancelled);
            bookingList.Add(booking3);
            BookingDetails booking4=new BookingDetails(customer2.CustomerID,0,new DateTime(2022,07,26),BookingStatus.Initiated);
            bookingList.Add(booking4);

            OrderDetails oreder1=new OrderDetails(booking1.BookingID,product1.ProductID,2,80);
            orderList.Add(oreder1);
            OrderDetails oreder2=new OrderDetails(booking1.BookingID,product2.ProductID,2,100);
            orderList.Add(oreder2);
            OrderDetails oreder3=new OrderDetails(booking1.BookingID,product3.ProductID,1,40);
            orderList.Add(oreder3);
            OrderDetails oreder4=new OrderDetails(booking2.BookingID,product1.ProductID,1,40);
            orderList.Add(oreder4);
            OrderDetails oreder5=new OrderDetails(booking2.BookingID,product2.ProductID,4,200);
            orderList.Add(oreder5);
            OrderDetails oreder6=new OrderDetails(booking2.BookingID,product10.ProductID,1,140);
            orderList.Add(oreder6);
            OrderDetails oreder7=new OrderDetails(booking2.BookingID,product9.ProductID,1,20);
            orderList.Add(oreder7);
            OrderDetails oreder8=new OrderDetails(booking3.BookingID,product2.ProductID,2,100);
            orderList.Add(oreder8);
            OrderDetails oreder9=new OrderDetails(booking3.BookingID,product8.ProductID,4,100);
            orderList.Add(oreder9);
            OrderDetails oreder10=new OrderDetails(booking3.BookingID,product1.ProductID,2,80);
            orderList.Add(oreder10);
        }
        public static void CustomerDetails()
        {
            currentRegister.ShowCustomerDetails();
        }
        public static void ShowProductDetails()
        {
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("|Product ID|Product Name|Quantity|Price|");
            System.Console.WriteLine("----------------------------------------");
            foreach(ProductDetails product in productList)
            {
                System.Console.WriteLine($"|{product.ProductID,-10}|{product.ProductName,-12}|{product.QuantityAvailable,-8}|{product.PricePerQuantity,-5}");
                System.Console.WriteLine("----------------------------------------");
            }
        }
        public static void WalletRecharge()
        {
            currentRegister.WalletRecharge();
        }
        public static void TakeOrder()
        {
            System.Console.WriteLine("Do you want to purchase(Yes/No):");
            string purchase=Console.ReadLine().ToLower();
            double totalPrice=0;
            if(purchase=="yes")
            {
                Lable:
                BookingDetails booking=new BookingDetails(currentRegister.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
                bookingList.Add(booking);
                ShowProductDetails();
                System.Console.WriteLine("Select the Product ID:");
                string productID=Console.ReadLine().ToUpper();
                bool temp=true,flag=true;
                foreach(ProductDetails product in productList)
                {
                    if(productID==product.ProductID)
                    {
                        System.Console.WriteLine("Enter the Quantity :");
                        int quantity=int.Parse(Console.ReadLine());
                        if(quantity<=product.QuantityAvailable)
                        {
                            double totalAmount=product.PricePerQuantity*quantity;
                            System.Console.WriteLine($"Price:{totalAmount}");
                            totalPrice+=totalAmount;
                            System.Console.WriteLine($"Total Price of all  Product :{totalPrice}");
                            OrderDetails order=new OrderDetails(booking.BookingID,product.ProductID,quantity,totalAmount);
                            tempOrderList.Add(order);
                            System.Console.WriteLine("You want to continue pruchase (Yes/No):");
                            string choice=Console.ReadLine().ToLower();
                            bool next=true;
                            if(choice!="yes")
                            {
                                System.Console.WriteLine("Thank You...");
                                next=false;
                            }
                            else
                            {
                                next=true;
                                goto Lable;
                            }
                            if(!next)
                            {
                                System.Console.WriteLine("Do you want to confirm the order(yes/no):");
                                string confirm=Console.ReadLine().ToLower();
                                if(confirm=="yes")
                                {
                                    Lable1:
                                    if(totalPrice<=currentRegister.WalletBalance)
                                    {
                                        booking.Status=BookingStatus.Booked;
                                        booking.TotalPrice=totalPrice;
                                        currentRegister.WalletBalance-=totalPrice;
                                        orderList.AddRange(tempOrderList);
                                        System.Console.WriteLine("Booking Successfully...");
                                        System.Console.WriteLine($"Your Booking ID is :{booking.BookingID}");
                                        product.QuantityAvailable-=quantity;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Insufficient Balance..");
                                        System.Console.WriteLine("Do you want to recharge (Yes/No):");
                                        string recharge=Console.ReadLine().ToLower();
                                        if(recharge=="yes")
                                        {
                                            currentRegister.WalletRecharge();
                                            goto Lable1;
                                        }
                                        else
                                        {
                                            foreach(OrderDetails order1 in tempOrderList)
                                            {
                                                if(order1.ProductID==product.ProductID)
                                                {
                                                    product.QuantityAvailable+=order1.ProductCount;
                                                    order1.ProductCount=0;
                                                    order1.BookingID="";
                                                    order1.ProductID="";
                                                    order1.PriceOfOrder=0;
                                                }
                                            }
                                            System.Console.WriteLine("Removed Succesfully...");
                                        }
                                    }
                                }
                                else
                                {
                                    System.Console.WriteLine("Thank You....");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            flag=false;
                        }
                        temp=true;
                        break;
                    }
                    else
                    {
                        temp=false;
                    }
                }
                if(!temp)
                {
                    System.Console.WriteLine("Invalid Product ID...");
                }
                if(!flag)
                {
                    System.Console.WriteLine("Invalid Quantity...");
                }
            }
            else
            {
                System.Console.WriteLine("Thank You Visit Again....");
            }
        }
        public static void ModifyOrderQuantity()
        {
            foreach(BookingDetails book in bookingList)
            {
                if(currentRegister.CustomerID==book.CustomerID && book.Status==BookingStatus.Booked)
                {
                    foreach(OrderDetails order in orderList)
                    {
                        if(book.BookingID==order.BookingID)
                        {
                            System.Console.WriteLine($"Order ID:{order.OrderID}  |Booking ID:{order.BookingID}   |Product ID:{order.ProductID}   |Purchase Quantity:{order.ProductCount}      |Price Of order:{order.PriceOfOrder}");

                        }
                    }
                }
            }
            System.Console.WriteLine("Pick the Order ID that you want to modify:");
            string orderID=Console.ReadLine().ToUpper();
            double newPrice=0;
            foreach(OrderDetails order in orderList)
            {
                if(order.OrderID==orderID)
                {
                    System.Console.WriteLine("Enter the quantity of the product:");
                    int newQuantity=int.Parse(Console.ReadLine());
                    foreach(ProductDetails product in productList)
                    {
                        if(order.ProductID==product.ProductID)
                        {
                            newPrice=newQuantity*product.PricePerQuantity;
                            order.PriceOfOrder+=newPrice;
                        }
                    }
                }
            }
        }
        public static void CancelOrder()
        {
            foreach(BookingDetails book in bookingList)
            {
                if(currentRegister.CustomerID==book.CustomerID && book.Status==BookingStatus.Booked)
                {
                    System.Console.WriteLine($"Booking ID:{book.BookingID}  Customer ID:{book.CustomerID}  Total price:{book.TotalPrice}  date of Booking:{book.DateOfBooking.ToString("dd/MM/yyyy")} Booking Status:{book.Status}");

                }
            }
            System.Console.WriteLine("Enter the Booking ID you want to cancel:");
            string bookingID=Console.ReadLine().ToUpper();
            foreach(BookingDetails book in bookingList)
            {
                if(book.BookingID==bookingID)
                {
                    book.Status=BookingStatus.Cancelled;
                    currentRegister.WalletBalance+=book.TotalPrice;
                    book.TotalPrice=0;
                    foreach(ProductDetails product in productList)
                    {
                        foreach(OrderDetails order in orderList)
                        {
                            if(order.ProductID==order.BookingID)
                            {
                                product.QuantityAvailable+=order.ProductCount;
                                order.ProductCount=0;
                                System.Console.WriteLine("Cancelled....");
                            }
                        }
                    }
                }
            }
        }
         private static void Subscribe()
                {
                    eventlink += new EventManager(Files.Create);
                    eventlink += new EventManager(Files.ReadFile);
                    eventlink += new EventManager(Mainmenu);
                    eventlink +=new EventManager(Files.WriteToFiles);
                }

                public static void Starter()
                {
                    Subscribe();
                    eventlink();
                }
    }
}