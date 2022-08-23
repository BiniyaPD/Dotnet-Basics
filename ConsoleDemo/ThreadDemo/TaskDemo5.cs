using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDemo.ThreadDemo
{
    public class TaskDemo5
    {
        public void Main()
        {
            var task1 = new Task(() => PrintData(1, 3000));
            var task2 = new Task(() => PrintData(2, 1000));
            var task3 = new Task(() => PrintData(3, 2000));
            task1.Start();
            task2.Start();
            task3.Start();

            Console.WriteLine("press any key exit");//Main thread execute first
            Console.ReadLine();
        }
        public void PrintData(int id, int sleepTime)//reuse the functionality
        {
            Console.WriteLine($"Task {id} started");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"Task {id} ended");
        }
    }
}
