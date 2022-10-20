using System;
using System.Collections.Generic;

namespace StudentAdmission1
{
    public static class Operations
    {
        public static List<StudentDetail> studentList = new List<StudentDetail>();
        public static List<Admission> admissionList = new List<Admission>();

        public static List<Department> departmentList = new List<Department>();
        public static void MainMenu()
        {
            string choice ="yes";
            do
            {
                    System.Console.WriteLine("Main Menu");
                    System.Console.WriteLine("\n 1.Register \n 2.Login \n 3.Exit");
                    int choice1 = int.Parse(Console.ReadLine());
                    switch(choice1)
                    {
                        case 1:
                        {
                        System.Console.WriteLine("User Regitration");
                        Registration();
                        
                        break;


                        }
                        case 2:
                        {
                            System.Console.WriteLine("User Login ");
                            Login();

                            break;
                        }
                        case 3:
                        {
                            System.Console.WriteLine("Exit Mainmenu");
                            choice="no";
                            break;
                        }

                    }
              

            }while (choice =="yes");


            
           static  void Registration()


            {
                System.Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                System.Console.WriteLine("Enter your father name");
                string fatherName = Console.ReadLine();
                System.Console.WriteLine("Enter gender options Male,Female,Transgender");
                Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
                System.Console.WriteLine("Enter your Date of birth");
                DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                System.Console.WriteLine("Enter Physics mark");
                int physics = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter chemistry mark");
                int chemistry = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter maths mark");
                int maths = int.Parse(Console.ReadLine());

                StudentDetail student = new StudentDetail(name,fatherName,gender,dob,physics,chemistry,maths);
                studentList.Add(student);
                System.Console.WriteLine("Student ID "+student.StudentId);
                System.Console.WriteLine("Registration successfull");
          
            }

            static void Login()
            {
               
                System.Console.WriteLine("Enter StudentId");
                string studentID = Console.ReadLine().ToUpper();
                int number=0;
                StudentDetail user;

                foreach ( StudentDetail studentId in studentList)
                {

                        if(studentID == studentId.StudentId)
                        {
                            System.Console.WriteLine("Valid User");
                            user = studentId;

                            SubMenu( user);
                            number=1;

                        }
              
                }

                if(number==0)
                 {
                    System.Console.WriteLine("Invalid user");
                 }
            }
            
          static void SubMenu(StudentDetail user)

       
           {
            string Choice="yes";
            double cutOff=75.0;
            do
            {
                 System.Console.WriteLine("Sub Menu created");
                 System.Console.WriteLine("Enter the option \n 1.CheckEligibility \n 2.Show Details \n 3. Show Admission Detail \n 4. Take Admission \n 5.Cancel Admission \n 6. Exit ");
                 int submenuCondition=int.Parse(Console.ReadLine());
                 switch(submenuCondition)
                 {
                    case 1:
                    {
                        bool result =   user. CheckEligibility(cutOff);
                        if (!result)
                        {
                            System.Console.WriteLine("You are not eligible");

                        }
                        else
                        {
                            System.Console.WriteLine("You are eligible");
                        }

                         break;
                    }
                    case 2:
                    {
                         ShowDetails(user);
                         break;
                    }
                    case 3:
                    { 
                            ShowAdmissionDetail(user);
                            break;

                    }
                    case 4:
                    {
                        TakeAdmission(user);
                        break;
                    }
                    case 5:
                    {
                        CancelAdmission(user);
                        break;
                    }
                    case 6:
                    {
                        Choice="no";
                        break;
                    }
                 }
            }while(Choice=="yes");
            
             
            }
        }
            static void ShowDetails(StudentDetail user)

            {
                System.Console.WriteLine("your ID:"+user.StudentId);
                System.Console.WriteLine("student name:"+user.Name);
                System.Console.WriteLine("father name:"+user.FatherName);
                System.Console.WriteLine("Date of birth:"+user.DateOfBirth);
                System.Console.WriteLine("Gender:"+user.Gender);
                System.Console.WriteLine("physics mark:"+user.PhysicsMark);
                System.Console.WriteLine("chemistry mark"+user.ChemistryMark);
                System.Console.WriteLine("Maths mark"+user.MathsMark);
            
            }
            
            static void  TakeAdmission(StudentDetail user)
            {

                foreach (Department  department in departmentList )
               {
                 System.Console.WriteLine("Department Id"+department.DepartmentId);
                 System.Console.WriteLine("Department "+department.DepartmentName);
                 System.Console.WriteLine("Seat available"+ department.NumberOfSeats);
               }
               System.Console.WriteLine("Enter department id");
               string department1 = Console.ReadLine().ToUpper();
               int number = 0;
               foreach(Department department in departmentList)

               {
                if (department1== department.DepartmentId)
                {    
                    number =1;
                    System.Console.WriteLine("Valid Department ID");

                    if (user.CheckEligibility(75.0))
                    {
                        System.Console.WriteLine("You are eligible");
                        if (department.NumberOfSeats>0)
                        {
                            System.Console.WriteLine("Seats available");

                            int result =0;
                            foreach(Admission admission in admissionList)
                            {
                                if (user.StudentId == admission.StudentId  && admission.AdmissionStatus == AdmissionStatus.Admitted)
                                {
                                    result=1;
                                    System.Console.WriteLine("You are already have admission");
                                }
                              

                            }  
                           if  (result==0)
                           {

                            department.NumberOfSeats--;
                            Admission create = new Admission(user.StudentId,department.DepartmentId,DateTime.Now,AdmissionStatus.Admitted);
                            admissionList.Add(create);
                            System.Console.WriteLine("Admission Process successfull . Admission ID "+create.AdmissionId);
                           }

                        }
                        else
                        {
                            System.Console.WriteLine("Seats Not available");

                        }

                    }
                    else
                    {
                        System.Console.WriteLine("You are not eligible");
                    }
              
              
                }

               }
               if(number == 0)
               {
                System.Console.WriteLine("Invalid department ID");


               }


            }
            static void CancelAdmission(StudentDetail user)
            {
                foreach(Admission admission in admissionList)
                {
                    if(user.StudentId == admission.StudentId && admission.AdmissionStatus == AdmissionStatus.Admitted)
                    {
                        admission.AdmissionStatus = AdmissionStatus.Canceled;
                       
                        foreach(Department department in departmentList)
                        {
                            if(admission.DepartmentId ==department.DepartmentId)
                            {
                                department.NumberOfSeats++;
                              System.Console.WriteLine("Your admission is cancelled");

                            }

                        }


                    }


                }
                

            }

            public static void ShowAdmissionDetail(StudentDetail user)
           {

            int number = 0;

            foreach(Admission admission in admissionList)
             {
                if(user.StudentId ==admission.StudentId)
                {
                   
                    System.Console.WriteLine("Admission Id"+admission.AdmissionId);
                    System.Console.WriteLine("Student Id "+admission.StudentId);
                    System.Console.WriteLine("Department Id"+admission.DepartmentId);
                    System.Console.WriteLine("Admission Date"+admission.Dob);
                    System.Console.WriteLine("Admission Status"+admission.AdmissionStatus);
                    number = 1;
                }
             }  
             if(number == 0)
             {
              System.Console.WriteLine("You are not taken admission");
             } 
             
           }

           public static void DefaultData()
           {
            StudentDetail student1  = new StudentDetail("Ravichanthar","Ettaparajan",Gender.Male,new DateTime(1999,9,9),90,90,90);
            StudentDetail student2 = new StudentDetail ("Baskar" ,"Sethurajan",Gender.Male,new DateTime(1999,9,9),90,90,90);
            
            studentList.Add(student1);
            studentList.Add(student2);
           
            Department department1 = new Department("EEE",29);
            Department department2 = new Department("CSE",29);
            Department department3 = new Department("MECH",30);
            Department department4 = new Department("ECE",30);
            
            departmentList.Add(department1);
            departmentList.Add(department2);
            departmentList.Add(department3);
            departmentList.Add(department4);

            Admission admision1 = new Admission(student1.StudentId,department1.DepartmentId,new DateTime(2022,10,17),AdmissionStatus.Admitted);
            Admission admision2 = new Admission(student2.StudentId,department2.DepartmentId,new DateTime(2022,10,17),AdmissionStatus.Admitted);

            admissionList.Add(admision1);
            admissionList.Add(admision2);

           }

       }
    }



            


                 
            
                 
              

            







