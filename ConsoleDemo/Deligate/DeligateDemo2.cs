using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo.Deligate
{
    delegate void TestProcess();
    public class DeligateDemo2
    {
        public void Test()
        {
            Console.WriteLine("Some test is done");
        }
        public void SendReport()
        {
            Console.WriteLine("Report Sending");
        }
        public void Main()
        {
            TestProcess testProcess = new TestProcess(Test);
            testProcess += new TestProcess(SendReport);
            testProcess.Invoke();
        }
    }
}
