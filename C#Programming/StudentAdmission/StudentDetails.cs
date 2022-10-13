namespace StudentAdmission
{

    public enum Gender{Default,Male,Female,Transgender}
    public class StudentDetails
    {
        private static int s_registrationNumber =3000;//field
        public string RegistrationNumber { get; } //property

        public string Name { get; set; } //auto property
        public string FatherName { get; set; }
        public Gender Gender{ get; set; }
        public int Age { get; set; }
        public string MailId { get; set; }
        public int PhysicsMark { get; set; }
        public int ChemistryMark { get; set; }
        public int MathsMark{ get; set; }
        

       public StudentDetails(string name,string fatherName,Gender gender,int age,string mail,int physics,int chemistry,int maths)
       {
        s_registrationNumber++;
        RegistrationNumber = "SF"+s_registrationNumber;

        Name =name;
        FatherName = fatherName;
        Gender= gender;
        Age =age;
        MailId =mail;
        PhysicsMark =physics;
        ChemistryMark =chemistry;
        MathsMark=maths;


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