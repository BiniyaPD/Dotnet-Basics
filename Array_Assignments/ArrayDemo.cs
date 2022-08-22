using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Array_Assignments
{
   class ArrayDemo
    {
        public void Main()
        {
            //int[] ar = { 1, 7, 'A', '>' };
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    Console.WriteLine(ar[i]+"\t");
            //}
            int x = 20;
            double m = 7;
            //int rr = x / m;
            int y = x;
            float f = x;
            double d = f;
            float r = (float)((float) x / m);
            Console.WriteLine($"Result={r}");
            Console.WriteLine($"Result={x/m}");
            Console.WriteLine($"X:{x}");
            Console.WriteLine($"y:{y}");
            Console.WriteLine($"f:{f}");
            Console.WriteLine($"d:{d}");
            //int p = int.Parse(Console.ReadLine());
            int[,] ar ={ { 1,2,3 },
                          { 3, 4,5} };
            Student student1 = new Student() { sid = 10, name = "babu" };
            Student student2 = new Student() { sid = 10, name = "babu" };
            if(student1.name==student2.name)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
