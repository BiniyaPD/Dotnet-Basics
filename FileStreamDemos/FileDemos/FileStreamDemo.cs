using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStreamDemos.FileDemos
{
    class FileStreamDemo
    {
        public void Main()
        {
            string path = @"D:\Temp Files\temp.txt";
            WriteToFile(path);
            ReadFromFile(path);
        }

        private void ReadFromFile(string path)
        {
            Console.WriteLine("Reading From the File");
            Console.WriteLine("---------------------------");
            string line = string.Empty;
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
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

        private void WriteToFile(string path)
        {
            string line = string.Empty;
            Console.WriteLine("Enter the Contents ,Enter 0 to exit");
            using(StreamWriter streamWriter=new StreamWriter(path,true))
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
    }
}
