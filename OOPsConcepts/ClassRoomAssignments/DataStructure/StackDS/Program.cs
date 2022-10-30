using System;
namespace StackDS;
class Program
{
    public static void Main(string[] args)
    {
        Stack<string> stack = new Stack<string>(3);
        stack.Push("Sneha");
        stack.Push("Priya");
        stack.Push("Kalai"); 
        stack.Push("Nivi");
        System.Console.WriteLine(stack.Peek());
        System.Console.WriteLine(stack.Pop());
        System.Console.WriteLine(stack.Contains("Sneha"));
        System.Console.WriteLine(stack.Contains("sneha"));

        Stack<int> stack1 = new Stack<int>();
    }
}