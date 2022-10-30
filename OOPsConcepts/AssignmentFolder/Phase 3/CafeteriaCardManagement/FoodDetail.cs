namespace CafeteriaCardManagement
{
    public class FoodDetail
    {
        private static  int s_foodId =100;
        public string FoodId { get; set; }

        public string FoodName { get; set; }
        public double FoodPrice { get; set; }

        public int AvailableQuantity { get; set; }

        public FoodDetail(string foodName,double foodPrice, int availableQuantity )
        {
            s_foodId++;
            FoodId ="FID"+s_foodId;
            FoodName  = foodName;
            AvailableQuantity = availableQuantity;
            
        }
      public FoodDetail(string data)
       {
          string[] value = data.Split(",");
           s_foodId  = int.Parse(value[0].Remove(0,2));
           FoodId = value[1];
           FoodName = value[2];
           AvailableQuantity = int.Parse(value[3]);
        
      }


    }
}