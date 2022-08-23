using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StreamOperations
{
    public class MenuDrivenFile
    {
        
        public void Main()
        {
           
            int choice=1;
            while(choice!=5)
            {
                Console.WriteLine("1.List all drives");
                Console.WriteLine("2.List all directories");
                Console.WriteLine("3.List all Files from the directory");
                Console.WriteLine("4.Search File");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter the choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:ListAllDrives();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Drive name:");
                        string drive = Console.ReadLine();
                        ListAllDirectories(drive);
                        break;
                    case 3:
                        Console.WriteLine("Enter the directory name:");
                        string directory = Console.ReadLine();
                        ListAllFiles(directory);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Main Directory");
                        string mainDirectory = Console.ReadLine();
                        Console.WriteLine("Enter the file Name");
                        string file = Console.ReadLine();
                        SearchFile(mainDirectory,file);
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                    default: Console.WriteLine("Invalid Choice");
                        break;

                }
            }

        }

        

        private void SearchFile(string directory,string file)
        {

            
            string[] fullFilePath = Directory.GetFiles(directory, file, SearchOption.AllDirectories);
            Console.WriteLine(fullFilePath);
            foreach (var item in fullFilePath)
            {
                Console.WriteLine($"file found at:{item}");
            }
        }
    

        private void ListAllDrives()
        {
            var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine(drive.Name);

            }
        }
        private void ListAllDirectories(string drive)
        {
            
            var drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                if (item.Name == drive)
                {
                    var directory = Directory.GetDirectories(drive);
                    foreach (var dir in directory)
                    {
                        Console.WriteLine(dir);


                    }
                }

            }
        }
        private void ListAllFiles(string directory)
        {
            try
            {
                //var dir = Directory.GetDirectories(directory);
                var files = Directory.GetFiles(directory);

                foreach (var file in files)
                {
                    Console.WriteLine(file);

                }
            }
            catch (Exception)
            {


            }
        }
    }

      
        
}

        
        
