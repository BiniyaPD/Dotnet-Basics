using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo
{
    class ArrayDemo3
    {
        public void Main()
        {
            int[] nos = new int[]
            {
                7,8,2,1,3,5,9,4,6
            };
            Console.WriteLine("Numbers are");
            for(int i=0;i<nos.Length;i++)
            {
                Console.WriteLine(nos[i]);
            }
            Array.Sort(nos);
            Console.WriteLine("Sorted Numbers are:");
            for (int i = 0; i < nos.Length; i++)
            {
                Console.WriteLine(nos[i]);
            }
        }
    }
}
