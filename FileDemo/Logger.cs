using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoggerFileDemo
{
    public class Logger : ILogger
    {
        string path = @"D:\LogFiles\";
        public void Main()
        {
            int a = 3;
            Logger logger = new Logger();
            try
            {
                int r = a / 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception.....Logged into File");
                string exe = DateTime.Now.ToLongTimeString()+" " + DateTime.Now.ToLongDateString()+"" + e.Message + e.StackTrace;
                WriteLog(exe);
            }
        }
        
        public void WriteLog(string message)
        {

            var fileName = DateTime.Now.ToString("dd-mm-yyyy")+".txt";
            string fullPath = string.Concat(path, fileName);
           if(File.Exists(fullPath))
           {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                   
                    sw.WriteLine(message);
                    sw.WriteLine("-------------------------------------------------------------------");
                }
                
            }
            else
            {
                File.Create(fullPath);
                using (StreamWriter sw = new StreamWriter(fullPath, false))
                {

                    sw.WriteLine(message);
                }

            }
        }
    }
}
