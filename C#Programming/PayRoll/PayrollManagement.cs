using System;

namespace PayRoll
{
    public class PayrollManagement
    {
        
        public string Name { get; set; }
        public DateTime DOB { get; set; }
       public float Mobile { get; set; }
       public string Gender { get; set; }

      public PayrollManagement(string name , DateTime dob,float mob,string gender)
      {
        Name=name;
        DOB=dob;
        Mobile=mob;
        Gender=gender;

      }

    }
}