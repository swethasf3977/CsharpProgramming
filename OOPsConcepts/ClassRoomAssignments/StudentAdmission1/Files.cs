using System;
using System.IO;

namespace StudentAdmission1
{
    public class Files
    {

        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");

            }
            if(!File.Exists("College/StudentDetail.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("College/StudentDetail.csv");
            }
             if(!File.Exists("College/Admission.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("College/Admission.csv");
            }
            if(!File.Exists("College/Department.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("College/Department.csv");
            }
            

        }

        public static void ReadLine()
        {
            string [] students =File.ReadAllLines("College/StudentDetail.csv");
            foreach(string data in students)
            {
                StudentDetail student = new StudentDetail(data);
                Operations.studentList.Add(student);

            }
            string [] user =File.ReadAllLines("College/Admission.csv");
            foreach(string data in user)
            {
               Admission student1 = new Admission(data);
                Operations.admissionList.Add(student1);

            }
            string [] dept  =File.ReadAllLines("College/Admission.csv");
            foreach(string data in dept)
            {
               Department dept1 = new Department(data);
                Operations.departmentList.Add(dept1);

            }





        }
        public static void WriteToFiles()
        {
            string[] studentDetail = new string [Operations.studentList.Count];
            for(int i = 0 ;i <Operations.studentList.Count;i++)
            {
                studentDetail[i] = Operations.studentList[i].StudentId+","+Operations.studentList[i].Name+","+ Operations.studentList[i].Gender+","+ Operations.studentList[i].DateOfBirth.ToString("dd/MM/yyy")+","+ Operations.studentList[i].PhysicsMark+","+ Operations.studentList[i].ChemistryMark+","+ Operations.studentList[i].MathsMark;

         
            }
            File.WriteAllLines("College/StudentDetail.csv",studentDetail);


            string[] admissionDetail = new string [Operations.admissionList.Count];
            for(int i = 0 ;i <Operations.admissionList.Count;i++)
            {
                admissionDetail[i] = Operations.admissionList[i].AdmissionId+","+Operations.admissionList[i].StudentId+","+Operations.admissionList[i].DepartmentId+","+Operations.admissionList[i].Dob.ToString("dd/MM/yyyy")+","+Operations.admissionList[i].AdmissionStatus;
         
            }
            File.WriteAllLines("College/Admission.csv",admissionDetail);


             string[] departmentDetail = new string [Operations.departmentList.Count];
            for(int i = 0 ;i <Operations.departmentList.Count;i++)
            {
                departmentDetail[i] = Operations.departmentList[i].DepartmentId+","+Operations.departmentList[i].DepartmentName+","+Operations.departmentList[i].NumberOfSeats;
            }
            File.WriteAllLines("College/Department.csv",departmentDetail);
        }
    
    }
}