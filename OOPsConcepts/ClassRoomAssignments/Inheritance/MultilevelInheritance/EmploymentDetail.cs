using System;
namespace MultilevelInheritance
{
    public class EmploymentDetail:StudentDetail
    {
        private static int s_employID = 1000;
        public string EmployID { get; set; }
        public DateTime RegistrationDate { get; set; }



       public EmploymentDetail(string studentID,string aid,string name, string fatherName,Gender gender,long phone,Department department):base(studentID,aid, name, fatherName, gender, phone,department)
       {
        s_employID++;
        EmployID = "EID"+s_employID;
        RegistrationDate = DateTime.Now;

       }
       public void ShowEmploymentDetail()
       {
        System.Console.WriteLine("Employment Id "+EmployID);
        System.Console.WriteLine("Student Id "+StudentId);
        Show();
        System.Console.WriteLine("Department "+Department);
        System.Console.WriteLine("Registration Date "+RegistrationDate.ToString("dd/MM/yyy"));
       }
        
    }
}