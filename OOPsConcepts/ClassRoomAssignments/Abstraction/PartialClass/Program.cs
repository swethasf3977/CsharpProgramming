using System;
namespace PartialClass;
class Program 
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee(1,"swe");
        employee.DisplayEmpInfo();
    }
}