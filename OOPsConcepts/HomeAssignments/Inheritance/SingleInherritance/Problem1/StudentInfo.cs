using System;
namespace Problem1
{
    public class StudentInfo:PersonInfo
    {
        private static int s_studentId = 1000;
        public string StudentId { get; set; }
        public string Branch { get; set; }
        public string Year{ get; set; }


        public StudentInfo(string name,string fatherName, long phone, DateTime dob ,string mailId,Gender gender,string branch ,string year):base( name, fatherName, phone, dob , mailId, gender)
        {
            s_studentId++;
            StudentId = "SID"+s_studentId;
            Branch = branch;
            Year = year;
        }
         public void ShowStudent()
        {
            System.Console.WriteLine("Student Id "+StudentId);
            ShowPerson(); 
            System.Console.WriteLine("Branch "+Branch +"\n Year"+Year);
        }
    }
}