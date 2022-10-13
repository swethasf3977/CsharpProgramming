using System;
namespace Password;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter password");
        String pass = Console.ReadLine();
        if (pass == "HiTeam")
        {
            System.Console.WriteLine("Right password");
        }
        else
        {
            System.Console.WriteLine("Wrong password");
        }
    }
}