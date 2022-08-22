using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Assignments
{
    public class ArrayAssignment
    {
        public void Main()
        {
            //int[] arr = new int[4];
            int[,] arr = new int[3, 3];
            int count = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = count++;
                }

            }
            Console.WriteLine("values from array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            PrintFRE(arr);
            PrintLRE(arr);
            PrintFCE(arr);
            PrintLCE(arr);
            PrintPDE(arr);
            PrintSDE(arr);


        }
        public void PrintFRE(int[,] arr)
        {
            Console.WriteLine("First Row Elements");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(arr[0, i] + "\t");
            }
            DrawLine(20, "-");
        }
        public void PrintLRE(int[,] arr)
        {
            Console.WriteLine("Last Row Elements");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(arr[2, i] + "\t");
            }

            DrawLine(20, "-");
        }
        public void PrintFCE(int[,] arr)
        {
            Console.WriteLine("First Column Elements");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(arr[i, 0] + "\t");
            }

            DrawLine(20, "-");
        }
        public void PrintLCE(int[,] arr)
        {
            Console.WriteLine("Last Column Elements");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(arr[i, 2] + "\t");
            }

            DrawLine(20, "-");
        }
        public void PrintPDE(int[,] arr)
        {
            Console.WriteLine("Primary Diagonal Elements");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(arr[i, i] + "\t");
            }

            DrawLine(20, "-");
        }
        public void PrintSDE(int[,] arr)
        {
            Console.WriteLine("Secondary Diagonal Elements");
            //for (int i = 0,j=2; i < 3 && j>=0; i++,j--)
            //{
            //    Console.Write(arr[i, j] + "\t");
            //}
            for (int i = 0; i < 3; i++)
            {
                int j = 2 - i;
                Console.Write(arr[i, j]+"\t");
            }

            DrawLine(20, "-");
        }
        private void DrawLine(int v1, string v2)
        {
            Console.WriteLine();
            for (int i = 1; i < v1; i++)
            {
                Console.Write(v2);
            }
            Console.WriteLine();


        }

    }

}
