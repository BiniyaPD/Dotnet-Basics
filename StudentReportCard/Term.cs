using System;
using System.Collections.Generic;
using System.Text;

namespace StudentReportCard
{
    public class Term
    {
        public string TermId { get; set; }

        private List<Subject> subjects = new List<Subject>();

        public void AddSubject(Subject subject)
        {
            this.subjects.Add(subject);
        }
        public IEnumerable<Subject> GetSubjects()
        {
            return this.subjects;
        }

        public double GetTermTotal()
        {
            
             double sum = 0;
            foreach (var subject in subjects)
            {
              
                sum += subject.ActualScore;

            }
            return sum;
        }
        public string GetTermResult()
        {
            string result = "Fail";
            double avg = 0;
            avg = GetTermTotal() / subjects.Count;
            if (avg >= 35 && avg < 50)
            {
                result = "C";
            }
            else if (avg >= 50 && avg < 70)
            {
                result = "B";
            }
            else if (avg >= 70 && avg < 85)
            {
                result = "A";
            }
            else if (avg >= 85)
            {
                result = "A+";
            }
            return result;
        }
            
        

    }
}
