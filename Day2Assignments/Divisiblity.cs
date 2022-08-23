using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{
    class Divisiblity
    {
        public void Main()
        {
            int range=0;
            Console.WriteLine("Enter the Range:");
            int.TryParse(Console.ReadLine(), out range);
            Console.WriteLine($"The numbers divisible by 1,3 and 7 in the range of 1 to {range} are :");
            DivisibleByNumber(range);
        }

        private void DivisibleByNumber(int range)
        {
            int num = 1;
            for (int i = 1; i <= range; i++)
            {
                if (num % 1 == 0 && num % 3 == 0 && num % 7 == 0)
                {
                    Console.WriteLine($"{num}\t");
                }
                num++;
            }
        }
    }
}
