using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDemo.ThreadDemo
{
    public class TaskDemo3
    {
        public void Main()
        {
            var task1 = new Task(() =>       //create a anonymous method
            {
                Console.WriteLine("Task1 started");
                Thread.Sleep(2000);
                Console.WriteLine("Task1 ended");
            });
            task1.Start();

            Console.WriteLine("press any key exit");//Main thread execute first
            Console.ReadLine();
        }
    }
}
