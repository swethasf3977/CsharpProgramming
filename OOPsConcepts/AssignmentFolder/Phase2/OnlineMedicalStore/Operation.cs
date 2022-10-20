using System;
using System.Collections.Generic;

namespace OnlineMedicalStore;

    public static class Operation
    {
         public static List<UserDetail> userList = new List<UserDetail>();
         public static List<MedicineDetail> medicineList = new List<MedicineDetail>();
         public static List<OrderDetail> orderList = new List<OrderDetail>();

        public static void MainMenu()
        {
            
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Enter your choice : \n 1.User Registration \n 2. User Login \n 3. Exit");
                int choice1 = int.Parse(Console.ReadLine());
          

                switch (choice1)
                {
                    case 1:
                    {
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Login();
                        break;
                    }
                    case 3:
                    {

                        System.Console.WriteLine("Exit Main menu");
                        choice = "no";
                        break;

                    }

                }

            }while(choice == "yes");


             static void Registration()
             {
                string choice = "yes";
                do
                {
                System.Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                System.Console.WriteLine("Enter your age");
                int age = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your city");
                string city = Console.ReadLine();
                System.Console.WriteLine("Enter your mobile");
                double mobile = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your initial balance");
                double balance = double.Parse(Console.ReadLine());

                UserDetail user1 = new UserDetail(name,age, city,mobile,balance);
                userList.Add(user1);
                System.Console.WriteLine("Your User Id is "+user1.UserId);
                System.Console.WriteLine("Registration Successfull !");
             
                choice = "no";
                }while(choice == "yes");

            }

            static void Login()
            {
                System.Console.WriteLine("Enter your user Id");
                string userID = Console.ReadLine().ToUpper();
                int number = 0;
                UserDetail user;
                foreach(UserDetail user1 in userList)
                {
                    if(userID == user1.UserId)
                    {  
                         number = 1;
                         System.Console.WriteLine("Valid user ID");
                         user = user1;
                         SubMenu(user);

                    }         

                }
                if(number == 0)
                {
                    System.Console.WriteLine("Invalid user Id");
                }

            }

            static void SubMenu(UserDetail user)
            {   
                string choice = "yes";

                do
                {
                System.Console.WriteLine("Enter your option : \n 1. Show medicine List \n 2.Purchace Medicine \n 3.Cancel medicine \n 4. Show purchace History \n 5.Recharge \n 6.Exit");
                int choice1 = int.Parse(Console.ReadLine());
                switch(choice1)
                {
                    case 1:
                    {   
                        showMedicine(user);
                        break;
                    }
                    case 2:
                    {
                        PurchaceMedicine(user);
                        break;
                    }
                    case 3:
                    {
                        CancelMedicine(user);
                        break;
                    }
                    case 4:
                    {
                        ShowHistory(user);
                        break;
                    }
                    case 5:
                    {
                       Recharge(user);
                        break;
                    }
                    case 6:
                    {   System.Console.WriteLine("Exit from submenu");
                        choice = "no";
                        break;
                        
                    }
                }
            }while(choice == "yes");
          }



          static void showMedicine(UserDetail user)
          {
            foreach(MedicineDetail medicine in medicineList)
            {
                System.Console.WriteLine("Medicine Id "+medicine.MedicineId);
                System.Console.WriteLine("Medicine Name "+medicine.MedicineName);
                System.Console.WriteLine("Medicine count of available "+medicine.MedicineCount);
                System.Console.WriteLine("Medicine Price "+medicine.MedicineName);
                System.Console.WriteLine("Medicine expiry date "+medicine.DateOfExpiry);
            }

          }
          static void PurchaceMedicine(UserDetail user)
          {
            System.Console.WriteLine("Enter Medicine Id");
            string medicineID = Console.ReadLine().ToUpper();
            int number =0;
            foreach(MedicineDetail medicine in medicineList)
            {
                if(medicineID == medicine.MedicineId)
                {
                    number = 1;
                    System.Console.WriteLine("Valid medicine Id");
                    System.Console.WriteLine("Enter the count of medicine");
                    int count = int.Parse(Console.ReadLine());
                    int number1 = 0;
                    foreach(MedicineDetail medicineCount in medicineList)
                    {
                        if(count < medicineCount.MedicineCount)
                        {
                            number1 = 1;
                            System.Console.WriteLine("Your count is available");
                            int number2 = 0;
                            foreach(OrderDetail order in orderList)
                            {
                                order.TotalPrice = order.TotalPrice +(medicineCount.MedicineCount*medicine.MedicinePrice);
                                if (order.TotalPrice < user.Balance)
                                {   number2 = 1;
                                    System.Console.WriteLine("Suffitiant Balance ");
                                   
                                    OrderDetail create = new OrderDetail(user.UserId,medicine.MedicineId,medicine.MedicineCount,order.TotalPrice,DateTime.Now,OrderStatus.Purchaced);
                                    orderList.Add(create);    
                                    medicine.MedicineCount--;
                                    System.Console.WriteLine("Your order placed successfully ");              

                                }
                            }
                            if(number2 == 0)
                            {  
                               System.Console.WriteLine("Insuffitient balance");
                               
                            }

                        }
                    }
                    if(number1 == 0)
                    {
                        System.Console.WriteLine("Your count of medicine is not available");
                    }

                }

            }
            if(number == 0)
            {
                System.Console.WriteLine("Invalid Medicine Id");
            }
            

          }

          static void CancelMedicine(UserDetail user)
          {
            foreach(OrderDetail order in orderList)
            {
                if(user.UserId == order.UserId)
                {
                    System.Console.WriteLine("Order ID "+order.OrderId);
                    System.Console.WriteLine("User ID "+order.OrderId);
                    System.Console.WriteLine("Medicine ID "+order.MedicineId);
                    System.Console.WriteLine("Medicine Count "+order.MedicineCount);
                    System.Console.WriteLine("Medicine total price "+order.TotalPrice);
                    System.Console.WriteLine("Medice ordered date "+order.DateOfOrder);
                    System.Console.WriteLine("Order status "+order.OrderStatus);

                    System.Console.WriteLine("Enter your order Id");
                    string orderID = Console.ReadLine();
                    foreach(MedicineDetail medicine in medicineList)
                    {
                        if(orderID == order.OrderId  && OrderStatus.Purchaced == order.OrderStatus )
                        {
                            medicine.MedicineCount++;
                            user.Balance = user.Balance +order.TotalPrice;
                            OrderDetail create1 = new OrderDetail(user.UserId,medicine.MedicineId,medicine.MedicineCount,order.TotalPrice,DateTime.Now,OrderStatus.Cancelled);
                            orderList.Add(create1);
                        }
                    }
                }
            }




          }
          static void ShowHistory(UserDetail user)
          {
            foreach(OrderDetail order in orderList)
            {
                if(order.UserId == user.UserId)
                {
                    System.Console.WriteLine("Order ID "+order.OrderId);
                    System.Console.WriteLine("User ID "+order.OrderId);
                    System.Console.WriteLine("Medicine ID "+order.MedicineId);
                    System.Console.WriteLine("Medicine Count "+order.MedicineCount);
                    System.Console.WriteLine("Medicine total price "+order.TotalPrice);
                    System.Console.WriteLine("Medice ordered date "+order.DateOfOrder);
                    System.Console.WriteLine("Order status "+order.OrderStatus);

                }

            }


          }

                    static void Recharge(UserDetail user)
                    {
                      System.Console.WriteLine("Enter your Recharge amount");
                      int amount = int.Parse(Console.ReadLine());
                               
                      user.Balance = user.Balance+amount;
                      System.Console.WriteLine("Recharged successfully");

                    }


        }


        public static void DefaultDate()
        {

            UserDetail user1 = new UserDetail("Ravi",33,"theni",8765677786,400);
            UserDetail user2 = new UserDetail("Baskar",33,"chenneai",8467483838,500);

            userList.Add(user1);
            userList.Add(user2);

            MedicineDetail medicine1 = new MedicineDetail("Paracitamol",40,5,DateTime.FromOADate(30/06/2022));
            MedicineDetail medicine2 = new MedicineDetail("Calpol",10,5,DateTime.FromOADate(30/15/2022));
            MedicineDetail medicine3 = new MedicineDetail("Gelucil",3,40,DateTime.FromOADate(30/04/2022));
            MedicineDetail medicine4 = new MedicineDetail("Metogel",5,50,DateTime.FromOADate(30/10/2022));
            MedicineDetail medicine5 = new MedicineDetail("Polivin Lodin",10,50,DateTime.FromOADate(30/10/2022));

            medicineList.Add(medicine1);
            medicineList.Add(medicine2);
            medicineList.Add(medicine3);
            medicineList.Add(medicine4);
            medicineList.Add(medicine5);


            OrderDetail order1 = new OrderDetail(user1.UserId,medicine1.MedicineId,3,15,DateTime.Now,OrderStatus.Purchaced);
            OrderDetail order2 = new OrderDetail(user1.UserId,medicine2.MedicineId,2,10,DateTime.Now,OrderStatus.Cancelled);
            OrderDetail order3 = new OrderDetail(user1.UserId,medicine4.MedicineId,2,100,DateTime.Now,OrderStatus.Purchaced);
            OrderDetail order4 = new OrderDetail(user2.UserId,medicine3.MedicineId,3,120,DateTime.Now,OrderStatus.Cancelled);
            OrderDetail order5 = new OrderDetail(user2.UserId,medicine5.MedicineId,5,250,DateTime.Now,OrderStatus.Purchaced);
            OrderDetail order6 = new OrderDetail(user2.UserId,medicine2.MedicineId,3,15,DateTime.Now,OrderStatus.Purchaced);

                    orderList.Add(order1);
                    orderList.Add(order2);
                    orderList.Add(order3);
                    orderList.Add(order4);
                    orderList.Add(order5);
                    orderList.Add(order6);



        }


        
    }
