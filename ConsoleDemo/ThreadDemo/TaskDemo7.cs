using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDemo.ThreadDemo
{
    public class TaskDemo7
    {
        public void Main()
        {
            var task1 = Task.Factory.StartNew(() => CreateAR(1, 5000)).ContinueWith((prevTask)=>SendAR(1,3000));
            var task2 = Task.Factory.StartNew(() => CreateAR(2, 2000)).ContinueWith((prevTask) => SendAR(2, 1000));
            var task3 = Task.Factory.StartNew(() => CreateAR(3, 1000)).ContinueWith((prevTask) => SendAR(3, 5000));

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
        public void CreateAR(int arID,int sleepTime)
        {
            //generate AR.pdf
            Console.WriteLine($"Creating AR with ID{arID}");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"Completed Creating AR with ID{arID}");
            //SendAR(arID, sleepTime);  //instead of explicititly calling we can use ContinueWith 
        }
        public void SendAR(int arID, int sleepTime)
        {
            //Sending AR.pdf
            Console.WriteLine($"Sending AR with ID{arID}");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"Completed Sending AR with ID{arID}");
        }
    }
}
