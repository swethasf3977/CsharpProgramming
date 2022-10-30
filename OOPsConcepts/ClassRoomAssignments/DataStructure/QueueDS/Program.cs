using System;
namespace QueueDS;
class Program
{
    public static void Main(string[] args)
    {
        Queue<string> myQueue = new Queue<string>(2);

        //Adding Elements
        myQueue.Enqueue("Sneha");
        myQueue.Enqueue("Nivetha");
        myQueue.Enqueue("Priya");
        myQueue.Enqueue("Swetha");
        myQueue.Enqueue("Kalai");


        //Checking Whether the Element Present or not
        System.Console.WriteLine(myQueue.Contains("Sneha")); 

        //Get the Head Element
        System.Console.WriteLine(myQueue.Peek());

        //Getting the Top Element
        System.Console.WriteLine(myQueue.Dequeue());
        System.Console.WriteLine(myQueue.Dequeue());
        System.Console.WriteLine(myQueue.Dequeue());
        System.Console.WriteLine(myQueue.Dequeue());
        System.Console.WriteLine(myQueue.Dequeue());
        System.Console.WriteLine(myQueue.Dequeue());

    }
}