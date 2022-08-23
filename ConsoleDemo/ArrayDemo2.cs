using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo
{
    class ArrayDemo2
    {
        public void Main()
        {
            //int[] arr = new int[4];
            int[,] arr = new int[3, 3];
            int count = 1;
            Console.WriteLine($"Length of the array:{arr.Length}");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    arr[i,j] = count++;
                }
                
            }
            Console.WriteLine("values from array");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write($"{arr[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Dimension of array:{arr.Rank}");
      
        }

        
    }
}
