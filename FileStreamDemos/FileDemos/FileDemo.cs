using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStreamDemos.FileDemos
{
    public class FileDemo
    {
        public void Main()
        {
            var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine($"Drive Name:{drive.Name}  Free space:{drive.AvailableFreeSpace}");
                var directories=Directory.GetDirectories(drive.Name);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Directories");
                Console.WriteLine("---------------------------------");
                foreach (var dir in directories)
                {
                    Console.WriteLine(dir);
                    
                    try
                    {
                        var files = Directory.GetFiles(dir);
                        Console.WriteLine("Files");
                        Console.WriteLine("---------------------------------");
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
    }
}
