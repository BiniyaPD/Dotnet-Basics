using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo
{
    class ArrayDemo4
    {
        public void Main()
        {
            int[][] nos = new int[3][];
            nos[0] = new int[] { 1, 2, 3 };
            nos[1] = new int[] { 100 };
            nos[2] = new int[] { 3,6,11,99,67,39,23 };
            for(int i=0;i<nos.Length;i++)
            {
                for (int j = 0; j < nos[i].Length; j++)
                {
                    Console.Write($"{nos[i][j]}"+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
