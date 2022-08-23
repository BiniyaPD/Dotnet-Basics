using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStreamDemos.FileDemos
{
    class FileClassDemo
    {
        public void Main()
        {
            string dirPath = @"D:\FileDemo";
            string filePath = @"D:\Demo\temp.txt";
            //check for directory
            CheckForDirectory(dirPath);
            //check for file
            CheckForFile(filePath);
            //Display all files and directories
            DisplayFilesAndDirectory(dirPath);
        }

        private void CheckForDirectory(string dirPath)
        {
            if(Directory.Exists(dirPath))
            {
                Console.WriteLine("Directory already exist");
            }
            else
            {
                Console.WriteLine("There is no such Directory:Do you want to create(y/n)");
                string choice = Console.ReadLine();
                if(choice.ToUpper()=="Y")
                {
                    Directory.CreateDirectory(dirPath);
                    Console.WriteLine($"Directory Created{dirPath}");
                }
            }
        }

        private void CheckForFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if(fileInfo.Exists)
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File does not exist.do you want to create a new file(y/n");
                string choice = Console.ReadLine();
                if(choice.ToUpper()=="Y")
                {
                    File.Create(filePath);
                    Console.WriteLine($"File Created:{filePath}");
                }
            }
        }

        private void DisplayFilesAndDirectory(string dirPath)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(dirPath))
                {
                    Console.WriteLine($"{dir} files");
                    foreach (string file in Directory.GetFiles(dir))
                    {
                        Console.WriteLine($"-->{file}");
                    }
                    DisplayFilesAndDirectory(dir);

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
