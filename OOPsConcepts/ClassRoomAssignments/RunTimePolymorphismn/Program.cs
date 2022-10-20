using System;
namespace RunTimePolymorphismn;
class Program 
{
    public static void Main(string[] args)
    {
        Total total = new Total();
        Student student;
        student = total; //pass childern class total object refernce to student object
        student.Name ="swe"; //student.Academic mark =100 /error//studnet. studnt name = "mani//error u cant pass value thou child propr
        student.Display();
       
       
        Sport sport = new Sport();
    
        student = sport;
        student.Name = "vasanth";
        student.Display();



        
    }
}