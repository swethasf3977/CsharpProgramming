namespace StudentAdmission1
{
    public class Department
    {
        private static int s_departmentID = 100;
        public string DepartmentId {get;}
        public string DepartmentName { get; set; }
        public int NumberOfSeats { get; set; }



        public Department(string departmentnName,int numberOfSeats)
        {

            s_departmentID++;
            DepartmentId = "DID"+s_departmentID;
            DepartmentName = departmentnName;
            NumberOfSeats = numberOfSeats;

        }
         public Department(string data)
        {
            string[] value = data.Split(",");
            s_departmentID = int.Parse(value[0].Remove(0,2));
            DepartmentId = value[1];
            DepartmentName = value[2];
            NumberOfSeats = int.Parse(value[3]);

        }


        
    }



}