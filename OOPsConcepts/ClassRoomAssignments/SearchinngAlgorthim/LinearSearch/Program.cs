using System;
namespace LinearSearch;
class Program 
{
    public static void Main(string[] args)
    {
        int[] arr = {3,58,920,583,572,45,878};
        int find = 9;
        for(int i = 0; i <= arr.Length-1;i++)
        {
            if(arr[i] ==find)
            {
                System.Console.WriteLine("Number located in the array ");
            }      
           
        }
      
    
        
    }
}