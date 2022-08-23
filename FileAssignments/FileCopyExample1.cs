using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileAssignments
{
    class FileCopyExample1
    {
        public void Main()
        {
            string oldPath = @"D:\Temp\temp.txt";
            string newPath = @"D:\Temp\subtemp\temp.txt";//check whether the file is copied to the sub folder
                                                          //its possible,no exceptions
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
