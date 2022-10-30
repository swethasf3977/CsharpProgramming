using System.IO;
namespace CafeteriaCardManagement;
  public class Files
    {
        //creating folder and files
         public static void Create()
        {
        if(!Directory.Exists("CafeteriaCardManagement"))
        {
            Directory.CreateDirectory("CafeteriaCardManagement");
            System.Console.WriteLine("Folder Created Successfully");
        }

        if(!File.Exists("CafeteriaCardManagement/UserDetail"))
        {
            File.Create("CafeteriaCardManagement/UserDetail.csv").Dispose();
        }
        if(!File.Exists("CafeteriaCardManagement/FoodDetail"))
        {
            File.Create("CafeteriaCardManagement/FoodDetail.csv").Dispose();
        }
        if(!File.Exists("CafeteriaCardManagement/CardItem"))
        {
            File.Create("CafeteriaCardManagement/CardItem.csv").Dispose();
        }
         if(!File.Exists("CafeteriaCardManagement/OrderDetail"))
        {
            File.Create("CafeteriaCardManagement/OrderDetail.csv").Dispose();
        }
    }
    //create files read
    public static void ReadFile()
    {
            string[] item1 = File.ReadAllLines("CafeteriaCardManagement/UserDetail.csv");
            foreach(string data in item1 )
            {
                UserDetail user = new UserDetail(data);
                Operation.userList.Add(user);
            }
            string[] item2 = File.ReadAllLines("CafeteriaCardManagement/FoodDetail.csv");
            foreach(string data in item2 )
            {
                FoodDetail food = new FoodDetail(data);
                Operation.foodList.Add(food);
            }
            string[] item3 = File.ReadAllLines("CafeteriaCardManagement/CardItem.csv");
            foreach(string data in item3)
            {
                CartItem card = new CartItem(data);
                Operation.cardList.Add(card);
            }
            string[] item4 = File.ReadAllLines("CafeteriaCardManagement/OrderDetail.csv");
            foreach(string data in item4)
            {
                OrderDetail order = new OrderDetail(data);
                Operation.orderList.Add(order);
            }
    }
    //create files to write
     public static void WriteToFiles()
        {
            string[] UserDetail = new string [Operation.userList.Count];
            for(int i = 0 ;i <Operation.userList.Count;i++)
            {
                UserDetail[i] = Operation.userList[i].UserID+","+Operation.userList[i].Name+","+Operation.userList[i].FatheName+","+Operation.userList[i].Gender+","+Operation.userList[i].Mobile+","+Operation.userList[i].MailId+","+Operation.userList[i].WalletBalance;
         
            }
            File.WriteAllLines("CafeteriaCardManagement/UserDetail.csv",UserDetail);


            string[] FoodDetail = new string [Operation.foodList.Count];
            for(int i = 0 ;i <Operation.foodList.Count;i++)
            {
                FoodDetail[i] = Operation.foodList[i].FoodId+","+Operation.foodList[i].FoodName+","+Operation.foodList[i].AvailableQuantity;
          
            }
            File.WriteAllLines("CafeteriaCardManagement/FoodDetail.csv",FoodDetail);
             
            string[] CardItem = new string [Operation.cardList.Count];
            for(int i = 0 ;i <Operation.cardList.Count;i++)
            {
               CardItem[i] = Operation.cardList[i].ItemId+","+Operation.cardList[i].OrderId+","+Operation.cardList[i].FoodId+","+Operation.cardList[i].OrderPrice+","+Operation.cardList[i].OrderQuantity;
          
            }
            File.WriteAllLines("CafeteriaCardManagement/CardItem.csv",CardItem);

            string[] OrderDetail = new string [Operation.orderList.Count];
            for(int i=0;i<=Operation.orderList.Count; i++)
            {
                OrderDetail[i] = Operation.orderList[i].OrderId+","+Operation.orderList[i].UserId+","+Operation.orderList[i].DateOfOrder+","+Operation.orderList[i].TotalPrice+","+Operation.orderList[i].Status;
            }
            File.WriteAllLines("CafeteriaCardManagement/OrderDetail.csv",OrderDetail);

    }
}
