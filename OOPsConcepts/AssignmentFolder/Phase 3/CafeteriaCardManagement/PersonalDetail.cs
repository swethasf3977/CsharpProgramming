namespace CafeteriaCardManagement
{
    public enum Gender{Default,Male,Female}
    public class PersonalDetail
    {
        public string Name { get; set; }
        public string FatheName { get; set; }
        public Gender Gender { get; set; }
        public string Mobile { get; set; }
        public string MailId{ get; set; }
        public PersonalDetail(string name, string fatherName,Gender gender,string mobile,string mailId)
        {
            Name = name;
            FatheName = fatherName;
            Gender = gender;
            Mobile = mobile;
            MailId = mailId;
        }
        public PersonalDetail(string data)
        {
            string[] value = data.Split(",");
            
            Name = value[0];
            FatheName =value[1];
            Gender = Gender.Parse<Gender>(value[2],true);
            Mobile = value[3];
            MailId = value[4];
        }
        
    }
}