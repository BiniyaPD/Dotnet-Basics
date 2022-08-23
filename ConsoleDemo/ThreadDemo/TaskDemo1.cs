using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.ThreadDemo
{
    public class TaskDemo1
    {
        public async void Main()
        {
            PrintNumber(10).Wait();
            Console.WriteLine();
        }
        public async Task PrintNumber(int no)
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= no; i++)
                {
                    Console.WriteLine($"{i}");
                }
            });
            
        }
    }
}
