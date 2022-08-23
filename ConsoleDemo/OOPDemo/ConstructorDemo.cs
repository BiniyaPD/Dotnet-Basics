using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo.OOPDemo
{
    public class ConstructorDemo
    {
        int x = 1;
        public ConstructorDemo()//zero parameterised constructor
        {
            x = 100;

        }
        public void Display()
        {
            Console.WriteLine($"X={x}");
        }
        public void Main()
        {

            ConstructorDemo obj = new ConstructorDemo();
            obj.Display();
        }
    }
}
