using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDemo.ThreadDemo
{
    public class ThreadDemo1
    {
        public void Main()
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "MyThread";
            Console.WriteLine($"Name:{thread.Name}");
            Console.WriteLine($"Priority:{thread.Priority}");
            Console.WriteLine($"CurrentCulture:{thread.CurrentCulture}");
            Console.WriteLine($"Alive Status:{thread.IsAlive}");
            thread.IsBackground = true;
            Console.WriteLine($"Background status:{thread.IsBackground}");
        }
    }
}
