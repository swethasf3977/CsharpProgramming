using System;
namespace MultipleInheritance;
class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails user = new PersonalDetails("Swetha","Vasanth",Gender.Female,97647737);
        user.Show();

        StudentDetail student = new StudentDetail(user.AID,user.Name,user.FatherName,Gender.Female,user.Phone,Department.CSE,"Final");
        student.ShowStudent();
        student.GetMark(90,80,60);
        student.Calculate();
        student.ShowMark();

        CustomerDetail customer = new CustomerDetail(user.AID,user.Name,user.FatherName,Gender.Female,user.Phone,5000);
        customer.ShowDetail();

        EmploymentDetail employee = new EmploymentDetail(student.StudentId,user.AID,user.Name,user.FatherName,Gender.Female,885995595,Department.EEE);
        employee.ShowEmploymentDetail();
        employee.GetMark(90,80,60);
        employee.Calculate();
        employee.ShowMark();
        
    }
}