using System;
using System.Collections.Generic;
using System.Text;

namespace XoriantTrainingModel
{
    public class HandsOnQuestion : Question
    {
        public string QuestionDesc { get; set; }
        public string ReferenceDocument { get; set; }

        public HandsOnQuestion( string questionDesc, string referenceDocument, int mark)
            : base(mark)
        {
            this.QuestionDesc = questionDesc;
            this.ReferenceDocument = referenceDocument;
        }
    }

}

