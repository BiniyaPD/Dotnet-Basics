using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{
    class MultiplicationTable
    {
        public void Main()
        {
            Console.WriteLine("Multiplication table for first five numbers:");
            Console.WriteLine("***********************************************");
            Multiplication();

        }

        private void Multiplication()
        {
            for(int i = 1; i <= 10; i++)
            {
                for( int j = 1; j<= 5; j++)
                {
                    Console.Write($"{i} * {j} = "+i*j+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
