namespace Problem2
{
    public enum Gender{Default,Female,Male}
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
    }
}