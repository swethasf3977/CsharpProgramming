using System;
namespace Season;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter season");
        string season = Console.ReadLine();

        if (season == "December"||season == "January"||season == "February")
        {
            System.Console.WriteLine("Winter");

        }
        else if (season == "March"|| season == "April"|| season == "May")
        {
            System.Console.WriteLine("Spring");

        }
        else if (season == "June" ||season=="July"||season =="August")
        {
            System.Console.WriteLine("Summar");

        }
        else
        {
            System.Console.WriteLine("Rain fall");

        }
            
            
    
    }
}