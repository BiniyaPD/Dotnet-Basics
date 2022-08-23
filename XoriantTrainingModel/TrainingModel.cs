using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XoriantTrainingModel
{
    public class TrainingModel
    {
        public string ClientName { get; set; }

        private List<Iteration> iterations = new List<Iteration>();

        public TrainingModel(string clientName, Iteration iteration1,Iteration iteration2,Iteration iteration3)
        {
            ClientName = clientName;
            this.iterations.Add(iteration1);
            this.iterations.Add(iteration2);
            this.iterations.Add(iteration3);
        }

       
        public IEnumerable<Iteration> GetIterations()
        {
            return this.iterations;
        }
        public int GetTotalScoreOfAllAssignment()
        {
            int score = 0;
            foreach (var iteration in iterations)
            {
                foreach (var iteration1 in iteration.Course.GetAssessments())
                {
                    score += iteration1.GetTotalMarks();
                }
                foreach (var iteration2 in iteration.GetAssessments())
                {
                    score += iteration2.GetTotalMarks();
                }
           
            }
            return score;
        }
        public int GetTotalAssessmentsInTheTraining()
        {
            int addAssessments = 0;
            int assessments = 0;
            foreach (var iteration in iterations)
            {
                addAssessments += iteration.GetAssessments().Count();
            }
            foreach (var iteration in iterations)
            {

               assessments += iteration.Course.GetAssessments().Count();
       
            }

            return addAssessments + assessments;
        }
    }
}
