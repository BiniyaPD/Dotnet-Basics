using System;
using System.Collections.Generic;
using System.Text;

namespace Day1Assignment
{
    public class BiggestOfThree
    {
        public void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            num3 = Convert.ToInt32(Console.ReadLine());
            //int big = Biggest(num1, num2, num3);
            int big = BiggestUsingTernary(num1, num2, num3);
            Console.WriteLine($"The Biggest of {num1},{num2},{num3} is {big}");
                
        }

        public int BiggestUsingTernary(int num1, int num2, int num3)
        {
            int big = (num1 > num2 && num1 > num3) ? num1 : (num2 > num3) ? num2 : num3;
            return big;
        }

        public int Biggest(int num1, int num2, int num3)
        {
            int big = num1;

            if (big < num2)
            {
                if (num2 > num3)
                {
                    big = num2;
                }
                else
                {
                    big = num3;
                }
            }

            return big;
        }
    }
}
