using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    public enum Department{Default,EEE,ECE,CSE}
    public enum Gender{Default,Male,Female,Transgender}
    public class UserDetail
    {
        private static int s_registrationId =3000;
        public string RegistrationId { get;  }
        public string StudentName { get; set; }
        public string MailId { get; set; }
        public Department Department{get;set;}
        public Gender Gender{get;set;}

        public UserDetail(string name,string mailId, Department departmentName , Gender gender)
        {
            s_registrationId++;
            RegistrationId="SF"+s_registrationId;

            StudentName = name;
            MailId = mailId;
            Department = departmentName;
            Gender = gender;

        }







        
    }
}