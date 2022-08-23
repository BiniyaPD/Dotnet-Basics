using System;
using System.Collections.Generic;
using System.Text;

namespace Day1Assignment
{
    class FibonnaciSeries
    {
        public void Main()
        {
            int limit = 0;
            Console.WriteLine("Enter the Limit:");
            limit = Convert.ToInt32(Console.ReadLine());
            Fibonnaci(limit);

        }

        public void Fibonnaci(int limit)
        {
            int first = 0, second= 1, third = 0;
            Console.Write(first+"\t"+second+"\t");
            while ((first+second) <= limit)
            {
                third = first + second;
                Console.Write(third + "\t");
                first = second;
                second = third;
                
            }
            
        }
    }
}
