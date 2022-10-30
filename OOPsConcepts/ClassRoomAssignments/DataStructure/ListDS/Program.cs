using System;
namespace ListDS;
class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();

        //To Add the Element into List
        list.Add(12);
        list.Add(10);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        //To Get the List Capacity
        System.Console.WriteLine(list.Capacity);

        //Creating Second List And Adding Element to it
        List<int> secondList = new List<int>();
        secondList.Add(10);
        secondList.Add(80);

        //Adding one List Element to Another List 
        list.AddRange(secondList);

        list.Insert(2 , 39);

        list.RemoveAt(2);

        foreach(int data in list)
        {
            System.Console.WriteLine(data);
        }
        for(int i=0 ; i<list.Count ; i++)
        {
            System.Console.WriteLine(list[i]);
        }  
    }
}