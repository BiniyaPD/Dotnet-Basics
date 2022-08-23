using System;
using System.Collections.Generic;
using System.Text;

namespace Day1Assignment
{
    class SwapNumber
    {
        public void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter the First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before Swapping\tFirst Number={num1}\tSecond Number={num2}");
            Swap(num1, num2);

        }

        public void Swap(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine($"After Swaping\tFirst Number={num1}\tSecond Number={num2}");
        }
    }
}
