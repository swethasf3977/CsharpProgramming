using System;
namespace InsertSorting;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of array ");
        int size = int.Parse(Console.ReadLine());
      //  System.Console.WriteLine("Enter the array values");
        int[] arr = new int[size];
         int i;
         int j;
        System.Console.WriteLine("Enter data");
        for( i = 0 ; i<size; i++)
        {
            
            arr[i] = int.Parse(Console.ReadLine());
             
        }
       
        for (i =1; i < arr.Length;i++)
        {
            int temp = arr[i];
             j = i-1;
            while((j>=0) && (arr[j])>temp)
            {
                arr[j+1] = arr[j];
                j = j -1;

            }
            arr[j+1] =temp;
             
        }
        
     System.Console.WriteLine("sorting array in ascending order");
      for(i=0;i<size;i++)
      {
        
        System.Console.WriteLine(arr[i]);
      }
       

    }
}