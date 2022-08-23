using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class MyClass
    {
        public void Show(int x)
        {
            if (x == 5)
            {
                Console.WriteLine("Number is 5");
                //break;
            }
            Console.WriteLine("Number is {(x + 5)}");
        }
    }
}
