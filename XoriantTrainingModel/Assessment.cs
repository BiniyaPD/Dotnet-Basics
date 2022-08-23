using System;
using System.Collections.Generic;
using System.Text;

namespace XoriantTrainingModel
{
    public class Assessment
    {
        public int AssessmentId { get; set; }
        public string Desc { get; set; }
        public int NoQoestions
        {
            get
            {
                return this.questions.Count;
            }
        }
        public DateTime DateAssessment { get; set; }
        private List<Question> questions = new List<Question>();
        public void AddQuestion(Question question)
        {
            this.questions.Add(question);
        }
        public IEnumerable<Question>GetQuestions()
        {
            return this.questions;
        }
        public int GetTotalMarks()
        {
            int total = 0;
            foreach (var question in questions)
            {
                total += question.Mark;
            }
            return total;
        }
        public int GetNumberMcq()
        {
            int mcqTotal = 0;
            foreach (var question in questions)
            {
                if(question is McqQuestion)
                {
                    mcqTotal++;
                }
            }
            return mcqTotal;
        }
        public int GetNumberHandson()
        {
            int handsonTotal = 0;
            foreach (var question in questions)
            {
                if (question is HandsOnQuestion)
                {
                    handsonTotal++;
                }
            }
            return handsonTotal;
        }
    }
}
