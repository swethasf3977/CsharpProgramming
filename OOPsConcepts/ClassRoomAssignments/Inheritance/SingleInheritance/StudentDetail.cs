namespace SingleInheritance
{
    public enum Department{Default,EEE,ECE,CSE}
    public class StudentDetail:PersonalDetails
    {
        private static int s_studentID = 1000;
        public string StudentId { get; set; }
        public Department Department { get; set; }
        public string Year {get;set;}


        public StudentDetail(string aid,string name, string fatherName,Gender gender,long phone,Department department,string year):base(aid, name, fatherName, gender, phone)
        {
            s_studentID++;
            StudentId = "SID"+s_studentID;
            Department = department;
            Year = year;

        }
        public void ShowStudent()
        {
            System.Console.WriteLine("Student Id "+StudentId);
            Show(); 
            System.Console.WriteLine("Department "+Department +"\n Year"+Year);
        }
        
    }
}