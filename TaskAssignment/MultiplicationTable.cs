using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAssignment
{
    public class MultiplicationTable
    {
        public void Main()
        {
            var task1 = Task.Factory.StartNew(() => PrintTable(5, 100));

            Console.WriteLine("press any key exit");
            Console.ReadLine();
        }
        public void PrintTable(int num,int sleepTime)
        {
            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write($"{j}*{i}={j*i}\t");
                    Thread.Sleep(sleepTime);
                }
                Console.WriteLine();
            }
        }
    }
}
