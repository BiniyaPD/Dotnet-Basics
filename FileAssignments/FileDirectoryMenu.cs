using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileAssignments
{
    class FileDirectoryMenu
    {
        public void Main()
        {
            int choice = 1;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("-------");
                Console.WriteLine("1.Create New File");
                Console.WriteLine("2.Copy File");
                Console.WriteLine("3.Rename File");
                Console.WriteLine("4.Delete File");
                Console.WriteLine("5.Create Directory");
                Console.WriteLine("6.Delete Directory");
                Console.WriteLine("7.Write To File");
                Console.WriteLine("8.Read From File");
                Console.WriteLine("9.Exit");
                Console.WriteLine("Enter the Choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Complete Path with File Name:");
                        string filePath = Console.ReadLine();
                        CreateFile(filePath);
                        break;
                    case 2: 
                        Console.WriteLine("Enter the old file Path");
                        string oldPath = Console.ReadLine();
                        Console.WriteLine("Enter the new Path");
                        string newPath = Console.ReadLine();
                        CopyFile(oldPath, newPath);
                        break;
                    case 3:
                        Console.WriteLine("Enter the old file Path with name");
                        string oldName = Console.ReadLine();
                        Console.WriteLine("Enter the  file Path with new name");
                        string newName = Console.ReadLine();
                        RenameFile(oldName, newName);
                        break;
                    case 4:
                        Console.WriteLine("Enter the file Path to delete the file");
                        string deleteFile = Console.ReadLine();
                        DeleteFile(deleteFile);
                        break;
                    case 5:
                        Console.WriteLine("Enter the Directory Name");
                        string directory = Console.ReadLine();
                        CreateDirectory(directory);
                        break;
                    case 6:
                        Console.WriteLine("Enter the Directory Name");
                        string dir = Console.ReadLine();
                        DeleteDirectory(dir);
                        break;
                    case 7: 
                        Console.WriteLine("Enter the File Name to Write the Contents");
                        string fileWrite = Console.ReadLine();
                        WriteToFile(fileWrite);
                        break;
                    case 8:
                        Console.WriteLine("Enter the File Name to Read the Contents");
                        string fileRead = Console.ReadLine();
                        ReadFromFile(fileRead);
                        break;
                    case 9:Environment.Exit(0);
                        break;
                }
            } while (choice != 10);
            
        }

        private void CreateFile(string filePath)
        {
            if(File.Exists(filePath))
            {
                Console.WriteLine("File Already Exist");
            }
            else
            {
                using(FileStream fs=File.Create(filePath))
                Console.WriteLine($"File Created:Path->{Path.GetFullPath(filePath)}");
            }
        }

        private void CopyFile(string oldPath, string newPath)
        {
            if (File.Exists(oldPath))
            {
                if (File.Exists(newPath))
                {
                    File.Delete(newPath);
                }
                File.Copy(oldPath, newPath);
                Console.WriteLine($"New File Copied and the location is" +
                    $"{Path.GetFullPath(newPath)}");
            }
            else
            {
                Console.WriteLine("No File to Copy");
            }
        }

        private void RenameFile(string oldName, string newName)
        {
            if (File.Exists(oldName))
            {
                if (File.Exists(newName))
                {
                    Console.WriteLine("The New suggested name is already exist");
                }
                File.Move(oldName, newName);
                Console.WriteLine($"{oldName} File name is changed to" +
                    $"{Path.GetFullPath(newName)}");
            }
            else
            {
                Console.WriteLine("No such file exist");
            }
        }

        private void DeleteFile(string deleteFile)
        {
            if (File.Exists(deleteFile))
            {
                File.Delete(deleteFile);
                Console.WriteLine("File Deleted");
            }
            else
            {
                Console.WriteLine("File Not exist");
            }
        }

        private void CreateDirectory(string directory)
        {
            if (Directory.Exists(directory))
            {
                Console.WriteLine("Directory already exist");
            }
            else
            {
                 Directory.CreateDirectory(directory);
                 Console.WriteLine($"Directory Created{directory}");
               
            }
        }

        private void DeleteDirectory(string dir)
        {
            if (Directory.Exists(dir))
            {
                Directory.Delete(dir);
                Console.WriteLine($"Directory Deleted:{dir}");
            }
            else
            {

                Console.WriteLine("No such Directory");
            }
        }

        private void ReadFromFile(string fileRead)
        {
            Console.WriteLine("Reading From the File");
            Console.WriteLine("---------------------------");
            string line = string.Empty;
            try
            {
                using (StreamReader streamReader = new StreamReader(fileRead))
                {
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        private void WriteToFile(string fileWrite)
        {
            string line = string.Empty;
            if (File.Exists(fileWrite))
            {

                Console.WriteLine("Enter the Contents ,Enter 0 to exit");
                using (StreamWriter streamWriter = new StreamWriter(fileWrite))
                {
                    line = Console.ReadLine();
                    while (line != "0")
                    {
                        streamWriter.Write(line);
                        line = Console.ReadLine();
                    }
                }
                Console.WriteLine("Completed writing");
            }
            else
            {
                Console.WriteLine("The File Not Exist");
            }
        }
           
    }
}
