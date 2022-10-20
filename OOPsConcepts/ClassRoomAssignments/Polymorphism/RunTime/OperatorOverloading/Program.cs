using System;
namespace OperatorOverloading;
internal class Program 
{
       public static void Main(string[] args)
    {
        Box box1 = new Box(20,2,120); //declare box1 of type 
        
        Box box2 = new Box(20,5,12); //declare box2 of type 
        
        Box box3 ;//declare box3 of type 

        double volume = box1.CalculateVolume();
        System.Console.WriteLine("Volume of box 1 "+volume);

        double volume2 = box1.CalculateVolume();
        System.Console.WriteLine("Volume of box 2 "+volume2);

        box3 = box1+box2; //add two objects
        box3.Add(box1,box2);
        double volume3 = box3.CalculateVolume(); //volume of box3;
        System.Console.WriteLine("Volume of box 3 "+volume3);
        Console.ReadKey();
        
          

    }
}
