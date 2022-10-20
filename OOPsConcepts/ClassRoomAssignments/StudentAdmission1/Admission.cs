using System;
using System.Collections.Generic;
namespace StudentAdmission1
{

    public enum AdmissionStatus{Default,Admitted,Canceled}
    public class Admission
    {
        private static int s_admissionId = 100;
        public string AdmissionId {get;}
        public string StudentId { get; set; }
        public string DepartmentId{get;set;}   
        public DateTime Dob { get; set; }   
        public AdmissionStatus AdmissionStatus{get; set;}


        public Admission(string studentId ,string departmentId,DateTime dob,AdmissionStatus admissionStatus)
        {
            s_admissionId++;
            AdmissionId = "AID"+s_admissionId;
            StudentId = studentId;
            DepartmentId = departmentId;
            Dob = dob;
            AdmissionStatus = admissionStatus;

        }
        public Admission(string data)
        {
            string[] value = data.Split(",");
            s_admissionId  = int.Parse(value[0].Remove(0,2));
            AdmissionId = value[0];
            StudentId = value[1];
            DepartmentId = value[2];
            Dob = DateTime.ParseExact(value[3],"dd/MM/yyyy",null);
            AdmissionStatus = Enum.Parse<AdmissionStatus>(value[4]);

        }


        
     }
               
  }
