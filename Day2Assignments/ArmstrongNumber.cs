using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{
    class ArmstrongNumber
    {
        public void Main()
        {
            int number = 0;
            Console.WriteLine("Enter the Number:");
            int.TryParse(Console.ReadLine(), out number);

            if(IsArmstrong(number))
            {
                Console.WriteLine($"The {number} is an Armstrong number");
            }
            else
            {
                Console.WriteLine($"The {number} is not an Armstrong number");
            }
            
        }

        private bool IsArmstrong(int num)
        {
            int sum = 0, digit = 0;
            int temp = num;
            bool flag = false;
            while(num != 0)
            {
                digit = num % 10;
                sum = sum + (digit * digit * digit);
                num = num / 10;
            }

            if(sum == temp)
            {
                flag = true;
            }
            return flag;
        }
    }
}
