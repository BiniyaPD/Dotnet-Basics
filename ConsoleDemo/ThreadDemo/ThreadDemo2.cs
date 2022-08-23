using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDemo.ThreadDemo
{
    public class ThreadDemo2
    {
        public void Main()
        {
            Thread thread = Thread.CurrentThread;
            Thread treeThread = new Thread(DrawTree);
            Thread roadThread = new Thread(DrawRoad);
            treeThread.IsBackground = true;
            roadThread.IsBackground = true;//so that these 2 thread will automatically ends its execution when the main thread close/end of game
            treeThread.Start();
            roadThread.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread in Main {thread.Name} is painting{i}");
                Thread.Sleep(100);
            }
            
            Console.WriteLine("End of Game");
        }
        public void DrawTree()
        {
            Thread thread = Thread.CurrentThread;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread in DrawTree {thread.Name} is painting{i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("End of DrawTree");
        }
        public void DrawRoad()
        {
            Thread thread = Thread.CurrentThread;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread in DrawRoad {thread.Name} is painting{i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("End of DrawRoad");
        }
    }
}
