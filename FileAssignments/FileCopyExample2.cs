using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileAssignments
{
    class FileCopyExample2
    {
        public void Main()
        {
            string oldPath = @"D:\Temp\temp.txt";
            string newPath = @"D:\Temp\subdemo\temp.txt";//Check whether the file is copied to the sub folder which does'nt exist
                                                         //Not possible,DirectoryNotFoundException
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
    }
}
