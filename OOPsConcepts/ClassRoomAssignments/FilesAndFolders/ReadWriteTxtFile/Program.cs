using System;
using System.IO;
namespace ReadWriteTxtFile;
class Program 
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("Test Folder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder created");
        }
        else 
        {
         System.Console.WriteLine("folder exist");
        }
        if (!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File created");
        }
        else
        {
            System.Console.WriteLine("file found");
        }

        System.Console.WriteLine("Select option : 1. Read file info  2. write file info");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                string line;
                StreamReader sr = null;
                try 
                {
                    sr = new StreamReader("TestFolder/Test.txt");
                    line = sr.ReadLine();
                    while(line != null)
                    {
                        System.Console.WriteLine(line);
                        line = sr.ReadLine();
                    }

                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception "+e.Message);
                }
                finally
                {
                    if(sr!=null)
                    {
                        System.Console.WriteLine("Excuting finally block ");
                        sr.Close();
                    }
                }
                break;
            }

            case 2:
            {
                StreamWriter sw = null;
                try
                {
                    string [] old = File.ReadAllLines("TestFolder/Test.txt");
                    //passing thhe file pathe and filename to the streamwritre constructor to open file
                    sw = new StreamWriter("TestFolder/Test.txt");
                    System.Console.WriteLine("Enter new content to be placed in file");
                    string info = Console.ReadLine();
                    string old1 = "";
                    foreach(string text in old)
                    {
                        old1=old1+"\n"+text; //append old tezt in file to make it as a single string

                    }
                    old1 = old1+"\n"+info; //append our new user input to old text
                    sw.WriteLine(); //write to file
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception "+e.Message);
                }
                finally
                {
                    //close file
                    if(sw != null)
                    {
                        sw.Close();
                    }                
                }
                break;
            }

        }
  






    }
}