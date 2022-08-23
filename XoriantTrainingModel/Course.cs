using System;
using System.Collections.Generic;
using System.Text;

namespace XoriantTrainingModel
{
    public class Course
    {
        public int CourseId { get; set; }
        public string courseName { get; set; }

        private List<Assessment> assessments = new List<Assessment>();

        public Course(int courseId, string courseName, Assessment assessment)
        {
            this.CourseId = courseId;
            this.courseName = courseName;
            this.assessments.Add(assessment);
        }

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
