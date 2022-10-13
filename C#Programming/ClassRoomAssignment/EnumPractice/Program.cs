using System;
namespace EnumPractice;

public enum Gender {Default,Male,Female,TransGender}

class Program 
{
    public static void Main(string[] args)
    {  

        //select by string and integer

        System.Console.WriteLine("Enter gender options Male,Female,Transgender");
        Gender gender1 = Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine(gender1);  

        //select by int

        System.Console.WriteLine("Enter gender options Male,Female,Transgender");
        Gender gender2  = Gender.Default;
        bool temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
        while (!temp || !((int) gender2 < 4 && (int) gender2>0))
        {
            System.Console.WriteLine("Invalid input");
            temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);

        }
        System.Console.WriteLine(gender2);

    }
        
 }
