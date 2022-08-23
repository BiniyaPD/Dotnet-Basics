using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class DerivedClass:BaseClass
    {
        public DerivedClass(int ii) : base(ii)
        {
            Console.Write("Derived");
        }
    }
}
