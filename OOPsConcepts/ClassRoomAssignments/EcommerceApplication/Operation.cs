using System;
using System.Collections.Generic;

namespace EcommerceApplication
{
    public static class Operation
    {
        public static List<CustomerDetail> customerList = new List<CustomerDetail>();
        public static List<ProductDetail> productList = new List<ProductDetail>();
        public static List<OrderDetails> orderList = new List<OrderDetails>();

        public static void MainMenu()
        { 
            string choice = "yes";
            do
            {

            System.Console.WriteLine("Choose your Option \n 1.Customer Registration \n 2.Login and Purchase \n 3.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {  
                    System.Console.WriteLine("Registration called");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login Called");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit Main Menu");
                    choice ="no";
                    break;
                 }


            }


            }while(choice =="yes");


            static void Registration()
            {
                System.Console.WriteLine("Enter Your name");
                string name = Console.ReadLine();
                System.Console.WriteLine("Enter your city");
                string city = Console.ReadLine();
                System.Console.WriteLine("Enter your Mobile number");
                double mobile = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your mailId");
                string mailId = Console.ReadLine();
                
                System.Console.WriteLine("Enter your initial balance");
                double balance = double.Parse(Console.ReadLine());

                CustomerDetail user = new CustomerDetail(name,city,mobile,mailId,balance);

                customerList.Add(user);
                System.Console.WriteLine("Your customer id "+user.CustomerId);
                System.Console.WriteLine("Registration Successfull");


            }

            static void Login()
            {
                System.Console.WriteLine("Enter your customer Id");
                string customerID = Console.ReadLine().ToUpper();
                int number = 0;
                CustomerDetail user;
                foreach(CustomerDetail customer in customerList)
                {
                    if (customerID == customer.CustomerId)
                    {
                        System.Console.WriteLine("Valid user");
                        user = customer;
                        SubMenu(user);
                        number = 1;

                    }

                }
                if(number == 0)
                {
                    System.Console.WriteLine("Invalid user");
                }


            }
            static void SubMenu(CustomerDetail user)
            {   

                string choice ="yes";
                do{
                System.Console.WriteLine("choose option :\n 1.Purchase \n 2.Order History \n 3.Cancell Order \n 4.wallet balance \n 5.Exit");
                int choice1 = int.Parse(Console.ReadLine());
                switch(choice1)
                {
                    case 1:
                    { 
                        Purchase(user);
                        break;
                    }
                    case 2:
                    {  
                        OrderHistory(user);
                        break;
                    }
                    case 3:
                    {
                        CancelOrder(user);
                        break;
                    }
                    case 4:
                    {
                         ShowBalance(user);
                        break;
                    }
                    case 5:
                    {  

                       break;
                    }


                }
                }while(choice =="yes");

            }

            static void Purchase(CustomerDetail user)
            {
                foreach(ProductDetail product in productList)
                {
                    System.Console.WriteLine("Product ID"+product.ProductId);
                    System.Console.WriteLine("Product Name"+product.ProductName);
                    System.Console.WriteLine("Product Available"+product.Stock);
                    System.Console.WriteLine("Product price"+product.Price);
                    System.Console.WriteLine("Shipping duration"+product.ShippingDuration);

                }
                System.Console.WriteLine("Enter product ID");
                 string product1 = Console.ReadLine().ToUpper();
                 int number = 0;
               
                 foreach(ProductDetail product in productList)
                 {  
                    double totalAmount;
                    if (product1 == product.ProductId)
                    {   
                         number=1;
                        System.Console.WriteLine("chose valid product");
                        System.Console.WriteLine("Enter product count");
                        int count = int.Parse(Console.ReadLine());
                        if(product.Stock > count)
                        {
                          
                          totalAmount = (count * product.Price) + 50;
                          if(user.WalletBalance > totalAmount)
                          {
                           // System.Console.WriteLine("The product is ordered");
                           user.WalletBalance =user.WalletBalance -totalAmount;
                           product.Stock = product.Stock-count;
                           DateTime result = (DateTime.Now).AddDays(product.ShippingDuration);
                             
                           System.Console.WriteLine("Your order placed sucessfully .Your order will be delivered on"+result);

                          }
                          else
                          {
                            System.Console.WriteLine("Insufficient balance.Please recharge your wallet");

                          }
                            
                        }
                        else
                        {
                            System.Console.WriteLine("Required count of product not available");
                        }
                    }


                 }
                 if(number ==0)
                 {
                    System.Console.WriteLine("Enter correct product ID");
                 }

            }

            static void OrderHistory(CustomerDetail user)
            {
                int number = 0;
                foreach (OrderDetails order in orderList)
                {
                    if(user.CustomerId == order.CustomerId)
                    {
                        System.Console.WriteLine("Order ID is "+order.OrderId);
                        System.Console.WriteLine("Customet ID "+order.CustomerId);
                        System.Console.WriteLine("Product ID "+order.ProductId);
                        System.Console.WriteLine("Date of order is "+order.DateOfOrder);
                        System.Console.WriteLine("Order quantity "+order.OrderQuantity);
                        System.Console.WriteLine("Order Status "+order.OrderStatus);
                        number =1;


                    }

                }
                if (number==0)
                {
                    System.Console.WriteLine("You are not ordered any before");
                }

            }
            static void  CancelOrder(CustomerDetail user)
            {
               
                 OrderHistory(user);
                 System.Console.WriteLine("Enter your Order Id to cancel order");
                 string orderID =Console.ReadLine().ToUpper();
                 foreach(OrderDetails order in orderList)
                {
                            if(orderID == order.OrderId )
                            {
                                
                                order.OrderStatus = OrderStatus.Cancelled;
                                foreach (ProductDetail product in productList )
                                {
                                    if(product.ProductId == order.ProductId)
                                    {
                                       
                                        product.Stock++;
                                        System.Console.WriteLine("Your order is cancelled");

                                        user.WalletBalance = user.WalletBalance +(product.Price);
                                        System.Console.WriteLine("Your amount is refunded . The amount is "+user.WalletBalance);

                                    }


                                }
                                
                            }
                }

            }
            static void ShowBalance(CustomerDetail user)
            {

                System.Console.WriteLine("Current balance is" +user.WalletBalance);

                System.Console.WriteLine("Do you want to recharge (YES/NO)?");
                string choice = Console.ReadLine().ToUpper();
                if (choice =="YES")
                {
                    System.Console.WriteLine("Enter your amount");
                    int amount = int.Parse(Console.ReadLine());
                    user.WalletBalance = amount+user.WalletBalance;
                    System.Console.WriteLine("Your updated balance "+user.WalletBalance);
                }
                else
                {
                    SubMenu(user);
                }

            }


          }
         public static void DefaultData()
            {
                CustomerDetail user1 = new CustomerDetail("Ravichandran","chennai",9089765534,"ravi@mail.com",5000);
                CustomerDetail user2 = new CustomerDetail("Baskar","chennai",980765788,"baskar@mail.com",50000);

                customerList.Add(user1);
                customerList.Add(user2);


                        ProductDetail product1 = new ProductDetail("Mobile",10,10000,3);
                        ProductDetail product2 = new ProductDetail("Tablet",5,15000,2);
                        ProductDetail product3 = new ProductDetail("camera",5,20000,4);
                        ProductDetail product4 = new ProductDetail("IPhone",5,50000,6);
                        ProductDetail product5 = new ProductDetail("laptop",5,40000,3);

                            productList.Add(product1);
                            productList.Add(product2);
                            productList.Add(product3);
                            productList.Add(product4);
                            productList.Add(product5);



                OrderDetails order1 = new OrderDetails(user1.CustomerId,product1.ProductId,20000,DateTime.Now,2,OrderStatus.Ordered);
                OrderDetails order2 = new OrderDetails(user2.CustomerId,product2.ProductId,20000,DateTime.Now,2,OrderStatus.Ordered);

                orderList.Add(order1);
                orderList.Add(order2);


            }

        
    }
}