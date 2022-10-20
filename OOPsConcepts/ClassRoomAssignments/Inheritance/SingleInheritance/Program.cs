using System;
namespace SingleInheritance;
class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails user = new PersonalDetails("Swetha","Vasanth",Gender.Female,97647737);
        user.Show();

        StudentDetail student = new StudentDetail(user.AID,user.Name,user.FatherName,Gender.Female,user.Phone,Department.CSE,"Final");
        student.ShowStudent();
        
    }
}