using System;
namespace ArrayAssignment;
class Program
{
    public static void Main(string[] args)
    {
        string[] names = {"Swetha","Sneha","Arthi","Bruntha","Divya"};
        
        foreach (string name in names)

        {
            System.Console.WriteLine(name);

        }
        System.Console.WriteLine("Enter name");
        string name1 = Console.ReadLine();
        int count = 0;
       
        for ( int i =0; i < names.Length; i++)
        {
            if ( names[i] == name1)
            { 
                  count ++;            

            }   
            
        }

        if (count == 1)
        {
            System.Console.WriteLine("Name present");
        }
        else 
        {
            System.Console.WriteLine("Not Present");
        }

        int count2 =0;
        foreach (string name2 in names)
        {
            if (name1 == name2)
            {
                count2++;
            }
        }
         if (count == 1)
        {
            System.Console.WriteLine("Name present");
        }
        else 
        {
            System.Console.WriteLine("Not Present");
        }

        
    }
}
