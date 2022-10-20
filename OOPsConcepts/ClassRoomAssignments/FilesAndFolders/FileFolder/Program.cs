using System;
using System.IO;
namespace FileFolder;
class Program 
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\SwethaVasanthakumar\OneDrive - Syncfusion\Desktop\MyFolder";

        string folderPath = path+"/Swe";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder not fount .So creating folder");
            Directory.CreateDirectory(folderPath);

        }
        else
        {
            System.Console.WriteLine("Directory Fount");
        }

        string filePath = path+"/newFile.txt";
        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("File not fount . So creating file");
            File.Create(filePath);
        }
        else
        {
            System.Console.WriteLine("file already exist");
        }

        System.Console.WriteLine("Enter your option : 1.create folder  2. create file  3.delete folder  4.delete file");
        int num = int.Parse(Console.ReadLine());
        switch(num)
        {
            case 1:
            {
                System.Console.WriteLine("Enter folder name you want to create");
                string name1 = Console.ReadLine();
                string newPath = path+"\\"+name1;
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                else
                {
                    System.Console.WriteLine("Directory already exist");
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter file name you want to create ");
                string fileName = Console.ReadLine();
                System.Console.WriteLine("Enter the file extension you want to create");
                string extension = Console.ReadLine();
                string newPath = path+"\\"+fileName+"."+extension;
                if (!File.Exists(newPath))
                {
                    File.Create(newPath);
                }
                else
                {
                    System.Console.WriteLine("File already exist");

                }
                break;
            }
         case 3:
            {
                foreach(string name in Directory.GetDirectories(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select folder you want to delete");
                string name1 = Console.ReadLine();
                string newPath = path+"\\"+name1;
                   try
                   {
                        foreach(string name in Directory.GetDirectories(path))
                        {
                            if(name==newPath)
                            {
                                Directory.Delete(newPath);
                                System.Console.WriteLine("Folder Deleted");
                            }

                        }
                   }
                   catch(DirectoryNotFoundException e)
                   {
                    System.Console.WriteLine("Directory not found");
                   }
                   break;

            }

            case 4:
            {
                foreach(string name in Directory.GetFiles(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select file name you want to delete");
                string  name1 =Console.ReadLine();
                System.Console.WriteLine("selcet file extension you want to delete");
                string name2 = Console.ReadLine();
                string newPath = path+"\\"+name1+"."+name2;
                foreach(string name in Directory.GetFiles(path))
                {
                    if(name == newPath)
                    {
                        File.Delete(newPath);
                        System.Console.WriteLine("file deleted");
                    }
                }
                break;
            }

        }
    }
}