using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDemo.ThreadDemo
{
    public class TaskDemo9
    {
        public void Main()
        {

            CancellationTokenSource sourse = new CancellationTokenSource();
            var token = sourse.Token;
            try
            {
                
                var task1 = Task.Factory.StartNew(() => CreateAR(1, 5000, token)).ContinueWith((prevTask) => SendAR(1, 3000));               
                var task2 = Task.Factory.StartNew(() => CreateAR(2, 2000, token)).ContinueWith((prevTask) => SendAR(1, 1000));
                var task3 = Task.Factory.StartNew(() => CreateAR(3, 1000, token)).ContinueWith((prevTask) => SendAR(1, 5000));
                sourse.Cancel();
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation cancelled");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
        public void CreateAR(int arID, int sleepTime,CancellationToken cancellationToken)
        {
            //generate AR.pdf
            //if the cancellation token is passed,cancel the execution
            if(cancellationToken.IsCancellationRequested)
            {
                cancellationToken.ThrowIfCancellationRequested();
            }
            Console.WriteLine($"Creating AR with ID{arID}");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"Completed Creating AR with ID{arID}");
            //SendAR(arID, sleepTime);  //instead of explicititly calling we can use ContinueWith 
        }
        public void SendAR(int arID, int sleepTime)
        {
            //Sending AR.pdf
            Console.WriteLine($"Sending AR with ID{arID}");
            Thread.Sleep(sleepTime);
            Console.WriteLine($"Completed Sending AR with ID{arID}");
        }
    }
}
