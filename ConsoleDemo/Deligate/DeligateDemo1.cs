using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo.Deligate
{
    delegate void Print();
    public class DeligateDemo1
    {
        public void display()
        {
            Console.WriteLine("Dispaly called");
        }
        public void show()
        {
            Console.WriteLine("Show called");
        }
        public void Main()
        {
            //DeligateDemo1 deligateDemo1 = new DeligateDemo1();
            //deligateDemo1.show();
            //deligateDemo1.display();
            Print print = new Print(show);
            print();
            print += new Print(display);//multitastdelegate
            print();
        }
    }
}
