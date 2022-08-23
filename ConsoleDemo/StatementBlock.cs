using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo
{
    class StatementBlock
    {
        public void Main()
        {
            int x = 10;
            if (x == 5)
            {
                int y = 50;//this is statement block variabe,it is not accessible outside the block
                Console.WriteLine($"The value of x is {x} and value of y is{y}");
                x += 10;
            }

            //Console.WriteLine($"After Checking for x as 5,the value of x is {x}"+
            //                $"Value of Y is {y});
        }
    }
}
