using System;

namespace StaticElements
{
    public  static class StudentInfo
    {
        public static int RegistarNumber; //static Field
        public static string Name { get; set; } //static property


       static StudentInfo() //static Constructor only for default value
       {
          RegistarNumber = 100;
          Name  = "Swetha";

       }
        public static void Display()
        {
              Console.WriteLine("RegistarNumber" + RegistarNumber);
              Console.WriteLine("Name" + Name);
        }
        
    }
}