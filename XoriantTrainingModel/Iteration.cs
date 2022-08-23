using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XoriantTrainingModel
{
    public class Iteration
    {
        public int IterationNo { get; set; }
        public string Goal { get; set; }
        public Course Course { get; set; }

        private List<Assessment> assessments = new List<Assessment>();

        public void AddAssessment(Assessment assessment)
        {
            this.assessments.Add(assessment);
        }
        public IEnumerable<Assessment> GetAssessments()
        {
            return this.assessments;
        }
       
    }
}
