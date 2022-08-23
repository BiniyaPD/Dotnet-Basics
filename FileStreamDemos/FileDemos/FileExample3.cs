using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStreamDemos.FileDemos
{
    class FileExample3
    {
        public void Main()
        {
            string oldPath = @"D:\Temp\temp.txt";
            string newPath = @"D:\Temp\newTemp.txt";
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
