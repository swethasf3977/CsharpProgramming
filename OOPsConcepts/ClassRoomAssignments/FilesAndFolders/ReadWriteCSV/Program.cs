using System;
using System.IO;
using System.Collections.Generic;
namespace ReadWriteCSV;
class Program 
{
     static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
        }
        else
        {
            System.Console.WriteLine("Folder found");
        }
        if(!File.Exists("TestFolder/Data.csv"))
        {
            System.Console.WriteLine("File doesn't found . creating new file");
            File.Create("TestFolder/Data.csv");  
        }
        else
        {
            System.Console.WriteLine("File Found");
        }

            List<Student> vlist =  new List<Student>();
            vlist.Add(new Student(){Name ="swetha",FatherName = "Vasanth",Gender = Gender.Female,DateOfBirth= new DateTime(2000,02,11)});
            vlist.Add(new Student(){Name ="nivi",FatherName = "Vasanth",Gender = Gender.Female,DateOfBirth= new DateTime(2000,02,20)});
            Insert(vlist);   
            Display();      

    }

    static void Insert(List<Student> vlist)
    {
        StreamWriter write = null;
        write = new StreamWriter(File.OpenWrite("TestFolder/Data.csv"));
        foreach(Student student in vlist)
        {
            write.WriteLine(student.Name+","+student.FatherName+","+student.Gender+","+student.DateOfBirth.ToString("dd/MM/yyy"));
        }
        write.Close();

    }
    static void Display()
    {
        StreamReader reader = null;
        List<Student> listA = new List<Student>();
        if (File.Exists("TestFolder/Data.csv"))
        {
            reader = new StreamReader(File.OpenRead("TestFolder/Data.csv"));
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var value = line.Split(",");
                if (value[0] != "")
                {
                    listA.Add(new Student(){Name = value[0],FatherName= value[1],Gender = Enum.Parse<Gender>(value[2]),DateOfBirth = DateTime.ParseExact(value[3],"dd/MM/yyyy",null)});
                     
                }

            }

        }
        else
        {
            System.Console.WriteLine("file doesn,t exist");
        }
            reader.Close();
            foreach(var coloum1 in listA)
            {
                System.Console.WriteLine("Your name \t"+coloum1.Name+"\t father name \t "+coloum1.FatherName+"\t date of birth \t"+coloum1.DateOfBirth+"\t gender \t"+coloum1.Gender+"\t ");
            }       

    }

}