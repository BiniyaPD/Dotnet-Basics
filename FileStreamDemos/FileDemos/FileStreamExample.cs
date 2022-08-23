using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStreamDemos.FileDemos
{
    class FileStreamExample
    {
        public void Main()
        {
            string path = @"D:\Temp Files\temp.txt";
            string message = "Good Morning! Have a nice day";
            WriteToFile(path,message);
            ReadFromFile(path);
        }

        private void ReadFromFile(string path)
        {
           if(!File.Exists(path))
            {
                Console.WriteLine("File Not Found");
            }
           using(FileStream fs=File.OpenRead(path))
            {
                byte[] msg = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(msg, 0, msg.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(msg));
                }
            }
        }

        private void WriteToFile(string path, string message)
        {
            if(File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path))
            {
                byte[] msg = new UTF8Encoding(true).GetBytes(message);
                fs.Write(msg, 0, msg.Length);
                Console.WriteLine("Writing Completed");
            }
        }
    }
}
