using System;
namespace Problem1
{
    public enum Gender{Default,Male, Female}
    public class PersonInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public DateTime Dob { get; set; }
        public string MailId { get; set; }
        public Gender Gender { get; set; }

        public PersonInfo(string name,string fatherName, long phone, DateTime dob ,string mailId,Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Dob = dob;
            MailId = mailId;
            Gender = gender;
        }
        public void ShowPerson()
        {
            System.Console.WriteLine("Name "+Name+" \n Father Name "+FatherName+"\n Phone "+Phone+ " \n DOB "+Dob+" \n MailId "+MailId+"\n Gender "+Gender);
            
        }
       

    }
}