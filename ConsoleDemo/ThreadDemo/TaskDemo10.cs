using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.ThreadDemo
{
    public class TaskDemo10
    {
        public void Main()
        {
            var nos = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 3, 14, 15, 16, 17, 18, 19, 20 };
            Parallel.ForEach(nos, (no) =>
            {
                 Console.WriteLine(no);
            });
        }
    }
}
