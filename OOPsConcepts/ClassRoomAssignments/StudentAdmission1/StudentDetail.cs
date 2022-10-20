using System;

namespace StudentAdmission1
{
    
    public enum Gender{Default,Male,Female,Transgender}
    public class StudentDetail

    {

       private static int s_studentId = 3000;
      public string StudentId { get; }
      public string Name { get; set; }
      public string FatherName { get; set; }
      public DateTime DateOfBirth { get; set; }
      public Gender Gender { get; set; }
      public int PhysicsMark { get; set; }
      public int ChemistryMark { get; set; }
      public int MathsMark { get; set; }

      public StudentDetail(string name,string fatherName,Gender gender,DateTime dob,int physics,int chemistry,int maths)
       {
        s_studentId++;
        StudentId= "SF"+s_studentId;

        Name =name;
        FatherName = fatherName;
        Gender= gender;
        DateOfBirth =dob;
       
        PhysicsMark =physics;
        ChemistryMark =chemistry;
        MathsMark=maths;
       }
       public StudentDetail(string data)
       {
        string[] value = data.Split(",");
        s_studentId = int.Parse(value[0].Remove(0,2));
        StudentId = value[0];
        Name = value[1];
        FatherName = value[2];
        Gender= Enum.Parse<Gender>(value[3]);
        DateOfBirth =DateTime.ParseExact(value[4],"dd/MM/yyyy",null);
        PhysicsMark =int.Parse(value[5]);
        ChemistryMark =int.Parse(value[6]);
        MathsMark=int.Parse(value[7]);
       }


        public bool CheckEligibility (double cutoff)
       {

                double average = (double) (PhysicsMark+ChemistryMark+MathsMark)/3;

                if (average > cutoff)
                {

                    return true;
                }
                else
                {
                    return false;
                }
       }

        
    }
}