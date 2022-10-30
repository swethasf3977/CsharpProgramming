using System;
namespace DictionaryDS;
class Program 
{
    public static void Main(string[] args)
    {
        Dictionary<long,string> phone = new Dictionary<long, string>();
        phone.Add(7647488889,"Swetha");
        phone.Add(9360052171,"Nivi");
        phone.Add(9360052171,"Rohan"); //identical keys throw exception

        foreach(KeyValuePair<long,string> data in phone)
        {
            System.Console.WriteLine("Key is "+data.Key+" Value is "+data.Value);
            
        }

        System.Console.WriteLine(phone[7647488889]); //print value of the key

        phone[7647488889] ="Mani";

         foreach(KeyValuePair<long,string> data in phone)
        {
            System.Console.WriteLine("Key is "+data.Key+" Value is "+data.Value);
            
        }
        
    }
}