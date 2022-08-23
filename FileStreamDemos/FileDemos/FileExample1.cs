using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStreamDemos.FileDemos
{
    class FileExample1
    {
        public void Main()
        {
            string path = @"D:\Temp\temp.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Exist");
            }
            else
            {
                Console.WriteLine("File Not Exist");
            }
        }
    }
}
