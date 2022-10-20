using System;
namespace Problem1;
class Program 
{
    public static void Main(string[] args)
    {
        PersonInfo person = new PersonInfo("Swetha","Vasanth",475884884,new DateTime(2000,02,11),"Swe@mailid",Gender.Female);
        person.ShowPerson();

        StudentInfo student = new StudentInfo(person.Name,person.FatherName,person.Phone,person.Dob,person.MailId,person.Gender,"EEE","Second");
        student.ShowStudent();
    }
}