using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo.OOPDemo
{
    class StaticDemo
    {
        int x = 0;//instance
        static int y = 0;//class,because all the instance access the same copy

        public void Display()
        {
            int z = 0;
            x++;
            y++;
            z++;
            Console.WriteLine($"X:{x}\tY:{y}\tZ:{z}");
        }
        public void Main()
        {
            StaticDemo staticDemo1 = new StaticDemo();
            StaticDemo staticDemo2 = new StaticDemo();

            staticDemo1.Display();
            staticDemo2.Display();
            staticDemo1.Display();
            staticDemo2.Display();
        }
    }
}
