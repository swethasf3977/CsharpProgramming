using System.IO;
namespace OnlineGroceryShop
{
    public class Files
    {
        public static void Create()
    {
        if(!Directory.Exists("OnlineGroceryShop"))
        {
            Directory.CreateDirectory("GroceryShop");
            System.Console.WriteLine("Folder Created Successfully");
        }

        if(!File.Exists("GroceryShop/Registration"))
        {
            File.Create("GroceryShop/Registration.csv").Dispose();
        }
        if(!File.Exists("GroceryShop/BookingDetails"))
        {
            File.Create("GroceryShop/BookingDetails.csv").Dispose();
        }
        if(!File.Exists("GroceryShop/OrderDetails"))
        {
            File.Create("GroceryShop/OrderDetails.csv").Dispose();
        }
        if(!File.Exists("GroceryShop/ProductDetails"))
        {
            File.Create("GroceryShop/ProductDetails.csv").Dispose();
        }
       
    }

    public static void ReadFile()
    {
            string[] user1 = File.ReadAllLines("GroceryShop/Registration.csv");
            foreach(string data in user1 )
            {
                Registration user = new Registration(data);
                Operations.registerList.Add(user);
            }
            string[] user2 = File.ReadAllLines("GroceryShop/BookingDetails.csv");
            foreach(string data in user2 )
            {
                BookingDetails book = new BookingDetails(data);
                Operations.bookingList.Add(book);
            }
   
            string [] user3  =File.ReadAllLines("GroceryShop/OrderDetails.csv");
            foreach(string data in user3)
            {
                OrderDetails theater = new OrderDetails(data);
                Operations.orderList.Add(theater);
            }
            string [] user4  =File.ReadAllLines("GroceryShop/ProductDetails.csv");
            foreach(string data in user4)
            {
                 ProductDetails movie = new ProductDetails(data);
                Operations.productList.Add(movie);
            }
                 
    }

     public static void WriteToFiles()
        {
            string[] Registration= new string [Operations.registerList.Count];
            for(int i = 0 ;i <Operations.registerList.Count;i++)
            {
                Registration[i] = Operations.registerList[i].CustomerID+","+Operations.registerList[i].Name+","+ Operations.registerList[i].FatherName+","+Operations.registerList[i].Gender+","+Operations.registerList[i].DOB+","+Operations.registerList[i].Mobile+","+Operations.registerList[i].MailID;
         
            }
            File.WriteAllLines("GroceryShop/Registration.csv",Registration);

            string[] BookingDetails = new string [Operations.bookingList.Count];
            for(int i = 0 ;i <Operations.bookingList.Count;i++)
            {
                BookingDetails[i] = Operations.bookingList[i].BookingID+","+Operations.bookingList[i].CustomerID+","+Operations.bookingList[i].TotalPrice+","+Operations.bookingList[i].DateOfBooking+","+Operations.bookingList[i].Status;
          
            }
            File.WriteAllLines("GroceryShop/BookingDetails.csv",BookingDetails);


             string[]OrderDetails = new string [Operations.orderList.Count];
            for(int i = 0 ;i <Operations.orderList.Count;i++)
            {
               OrderDetails[i] = Operations.orderList[i].OrderID+","+Operations.orderList[i].BookingID+","+Operations.orderList[i].ProductID+","+Operations.orderList[i].ProductCount;
            }
            File.WriteAllLines("GroceryShop/OrderDetails.csv",OrderDetails);

            string[] ProductDetails = new string [Operations.productList.Count];
            for(int i = 0 ;i <Operations.productList.Count;i++)
            {
              ProductDetails[i] = Operations.productList[i].ProductID+","+Operations.productList[i].ProductName+","+Operations.productList[i].QuantityAvailable+","+Operations.productList[i].PricePerQuantity;
            }
            File.WriteAllLines("GroceryShop/ProductDetails.csv",ProductDetails);


        }

        
    }
}