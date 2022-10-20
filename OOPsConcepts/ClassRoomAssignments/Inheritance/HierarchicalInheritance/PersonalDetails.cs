namespace HierarchicalInheritance
{
    public enum Gender {Default,Male,Female}
    public class PersonalDetails
    {
        private static int s_aID = 1000;
        public string AID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }

        public PersonalDetails(string name, string fatherName,Gender gender,long phone)
        {
            s_aID++;
            AID = "AID"+ s_aID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Phone = phone;

        }
        public PersonalDetails( string aid,string name, string fatherName,Gender gender,long phone)
        {
           
            AID = aid;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Phone = phone;

        }
        
        public void Show()
        {
            System.Console.WriteLine("ID"+AID+ "\n Name"+Name+"\n FatherName "+FatherName+"\n Gender "+Gender+"\n phone "+Phone );
        }


    }
}