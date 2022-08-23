using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDemo.ThreadDemo
{
    public class Printer
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    public class PrintManager
    {
        private readonly Printer printer;
        private readonly string message;

        public PrintManager(Printer printer,string message)
        {
            this.printer = printer;
            this.message = message;
        }
        public void Run()
        {
            //lock (printer)
            //{

            //}
            Monitor.Enter(printer);

            try
            {
                this.printer.Print(this.message);
            }
            catch (Exception)
            {

            }
            Monitor.Exit(printer);
        }
    }
    public class ThreadDemo3
    {
        public void Main()
        {
            Printer printer = new Printer();
            PrintManager printManager1 = new PrintManager(printer, "One");//100page
            PrintManager printManager2 = new PrintManager(printer, "Two");//200 page
            PrintManager printManager3 = new PrintManager(printer, "Three");//500 page

            Thread t1 = new Thread(new ThreadStart(printManager1.Run));
            Thread t2 = new Thread(new ThreadStart(printManager2.Run));
            Thread t3 = new Thread(new ThreadStart(printManager3.Run));
            t1.Start();
            t2.Start();
            t3.Start();
            //printManager1.Run();
            //printManager2.Run();
            //printManager3.Run();
        }
    }
}
