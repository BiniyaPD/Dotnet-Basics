using System;
using System.Collections.Generic;
using System.Text;

namespace XoriantTrainingModel
{
    public class McqQuestion : Question
    {
        public string QuestionName { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string RightOption { get; set; }

        public McqQuestion(string questionName, string option1, string option2, string rightOption, int mark)
            :base(mark)
        {
            this.QuestionName = questionName;
            this. Option1 = option1;
            this.Option2 = option2;
            this.RightOption = rightOption;
        }

        public McqQuestion(string questionName, string option1, string option2, string option3, string option4, string rightOption, int mark)
            :base(mark)
        {
            this.QuestionName = questionName;
            this.Option1 = option1;
            this.Option2 = option2;
            this.Option3 = option3;
            this.Option4 = option4;
            this.RightOption = rightOption;
        }
    }
}
