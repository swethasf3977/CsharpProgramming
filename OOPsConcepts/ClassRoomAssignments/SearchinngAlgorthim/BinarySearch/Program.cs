using System;
namespace BinarySearch;
class Program 
{
    public static void Main(string[] args)
    {
        int[] arr = {3,6,9,24,98,100,133,};
        int find = 91;
        int start =0;
        int midle;
        int end;   
        end = arr.Length-1; 
        while(start <= end)
        {
           
            midle = (start+end)/2;

            if(find == arr[midle])
            {
                System.Console.WriteLine("found the value");
                break;
            }
            else if(find<arr[midle])
            {
                    end = midle-1;
            }
            else
              {
               start = midle+1;
              }
            }
        }

       }
    
