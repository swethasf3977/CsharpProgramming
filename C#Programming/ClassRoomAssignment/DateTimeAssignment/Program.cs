using System;
namespace DateTimeAssignment;
class Program 
{
    public static void Main(string[] args)
    {
       DateTime dt1 = new DateTime(2021,8,10,10,40,32);
     //  System.Console.WriteLine(dt1.ToString());
         Console.WriteLine(dt1.Year); 
         Console.WriteLine(dt1.Month);
         Console.WriteLine(dt1.Day);
         Console.WriteLine(dt1.Hour);
         Console.WriteLine(dt1.Minute);
         Console.WriteLine(dt1.Second);

       // 2nd
        string dt2 = (dt1.ToString("yyyy/MM/dd hh/mm/ss tt"));
        string[] dt3 = dt2.Split(' ', '/');
       for (int i = dt3.Length-1; i>=0 ; i--)
       {
         System.Console.Write(dt3[i]+" ");
       }


       //3 rd
       
      
     Console.WriteLine(" \n Enter your date of birth dd/MM/yyyy format");
     DateTime dt4 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);// Parse exact
     Console.WriteLine(dt4.ToString("dd/MM/yyyy"));


    }
}