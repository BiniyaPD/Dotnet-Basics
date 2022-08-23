using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class MyRepo
    {
        private IEnumerable names = null;
        public void Init()
        {
            this.names.Add("A");
            this.names.Add("B");
            this.names.Add("C");
            this.names.Add("D");
        }
        public void Show()
        {
            foreach (var item in this.names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
