using System;
namespace HierarchicalInheritance;
class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails user = new PersonalDetails("Swetha","Vasanth",Gender.Female,97647737);
        user.Show();

        StudentDetail student = new StudentDetail(user.AID,user.Name,user.FatherName,Gender.Female,user.Phone,Department.CSE,"Final");
        student.ShowStudent();

        CustomerDetail customer = new CustomerDetail(user.AID,user.Name,user.FatherName,Gender.Female,user.Phone,5000);
        customer.ShowDetail();
        
    }
}