using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class ArrayDemo1
    {
        public void Main()
        {
            int[] nos = { 1, 'A', 3, 'B', 5 };
            for (int i = 0; i < nos.Length; i++)
            {
                Console.WriteLine($"{nos[i]}");
            }
            foreach (var item in nos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Rank of Array:{nos.Rank}");
        }
    }
}
