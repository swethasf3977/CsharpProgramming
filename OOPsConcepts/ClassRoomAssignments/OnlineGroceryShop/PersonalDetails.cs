using System;
namespace OnlineGroceryShop
{
    public enum Gender{Default,Male,Female}
    public class PersonalDetails
    {
        public string Name{get; set;}
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string MailID { get; set; }

        public PersonalDetails(string name,string fatherName,Gender gender,long mobile,DateTime dob,string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            MailID=mailID;
        }     
         public PersonalDetails(string data)
        {
            string[] value = data.Split(","); 
            Name = value[0];
            FatherName = value[1];
            Gender =  Gender.Parse<Gender>(value[2],true);
            Mobile = long.Parse(value[3]);
            DOB = DateTime.Parse(value[4]);
            MailID = value[5];
           
          
        }
  
        
        
        
    }
}