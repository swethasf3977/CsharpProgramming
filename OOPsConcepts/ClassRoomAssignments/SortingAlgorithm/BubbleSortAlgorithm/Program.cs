using System;
namespace BubbleSortAlgorithm;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[] {23,894,2,9,1,45,343,554};
        int i,j,temp = 0;
        for(i=0; i<arr.Length;i++)
        {
            for(j=i+1;j<arr.Length;j++)
            {
                if(arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
            }
            System.Console.WriteLine(arr[i] );
        }
        
    }
}