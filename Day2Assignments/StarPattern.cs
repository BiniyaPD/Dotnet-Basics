using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{ 
    class StarPattern
    {
        public void Main()
        {
            int number = 0;
            Console.WriteLine("Enter the number :");
            int.TryParse(Console.ReadLine(), out number);

            Console.WriteLine("The patterns are :");
            Pattern1(number);
            Console.WriteLine("\n");
            Pattern2(number);
            Console.WriteLine("\n");
            Pattern3(number);

        }

        private void Pattern1(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j =1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private void Pattern2(int n)
        {
            int temp = n;

            for(int i = 1; i <= n; i++)
            {
                Whitespace(temp, i);

                for(int k= 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        private void Whitespace(int temp,int i)
        {
            if (i < temp)
            {
                Whitespace(temp - 1, i);
                Console.Write(" ");
            }  
        }

        private void Pattern3(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j =1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
