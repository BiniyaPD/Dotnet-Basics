using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDemo.ThreadDemo
{
    public class TaskDemo2
    {
        public void Main()
        {
            Task drawTreeTask = new Task(DrawTree);
            Task drawRoadTask = new Task(DrawRoad);
            drawTreeTask.Start();
            drawRoadTask.Start();
            drawTreeTask.Wait();//to execute these methods synchronously
            drawRoadTask.Wait();//wait till other threads gets executed
            Console.WriteLine("End of Game");
        }
        public void DrawTree()
        {
            
            Console.WriteLine("End of DrawTree");
            Thread.Sleep(100);
        }
        public void DrawRoad()
        {
            
            Console.WriteLine("End of DrawRoad");
            Thread.Sleep(100);
        }
    }
}
