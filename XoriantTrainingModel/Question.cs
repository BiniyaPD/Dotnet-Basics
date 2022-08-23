using System;
using System.Collections.Generic;
using System.Text;

namespace XoriantTrainingModel
{
    public abstract class Question
    {
        public int Mark { get; set; }
        public Question(int mark)
        {
            this.Mark = mark;
        }
    }
}
