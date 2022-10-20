namespace MultipleInheritance
{
    public enum Department{Default,EEE,ECE,CSE}
    public class StudentDetail:PersonalDetails,IMarkDetail
    {
        private static int s_studentID = 1000;
        public string StudentId { get; set; }
        public Department Department { get; set; }
        public string Year {get;set;}

        public int Physics {get;set;}
        public int Chemisty{get;set;}
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }

        public StudentDetail(string aid,string name, string fatherName,Gender gender,long phone,Department department,string year):base(aid, name, fatherName, gender, phone)
        {
            s_studentID++;
            StudentId = "SID"+s_studentID;
            Department = department;
            Year = year;

        }

        public StudentDetail(string studentID,string aid,string name, string fatherName,Gender gender,long phone,Department department):base(aid, name, fatherName, gender, phone)
        {
            StudentId = studentID;
            Department = department;

        }

        public void GetMark(int physics,int chemisty,int maths)
        {
            Physics = physics;
            Chemisty = chemisty;
            Maths = maths;
          
        }

        public void Calculate()
        {
             Total = Physics+Chemisty+Maths;
            Average = (double)Total/3;
        }

        public void ShowMark()
        {
            System.Console.WriteLine("Physics "+Physics + " Chemistry "+Chemisty+" Maths "+Maths);
            System.Console.WriteLine("Total "+Total+ " Average "+Average);

        }

        public void ShowStudent()
        {
            System.Console.WriteLine("Student Id "+StudentId);
            Show(); 
            System.Console.WriteLine("Department "+Department +"\n Year"+Year);
        }
        
    }
}