using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStreamDemos.FileDemos
{
    class FileExample2
    {
        public void Main()
        {
            string path = @"D:\Temp\temp1.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File exist");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File Created");
            }
        }
        

    }
}
