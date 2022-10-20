
namespace MultiPathInheritance
{
    class Student : ISport,IAcademic
    {
        public int AcademicMark { get; set; }
        public string Name { get; set; }
        public int SportMark { get; set; }

        public Student(string name,int academicMark,int sportMark)
        {
            Name = name;
            AcademicMark = academicMark;
            SportMark = sportMark;

        }
        public void Display()
        {
            System.Console.WriteLine("Name "+Name+" Total Mark "+(SportMark+AcademicMark));
        }
    }
}