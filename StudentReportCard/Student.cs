using System;
using System.Collections.Generic;
using System.Text;

namespace StudentReportCard
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        private List<Term> terms = new List<Term>();

        public void AddTerm(Term term)
        {
            this.terms.Add(term);
        }
        public IEnumerable<Term> GetTerms()
        {
            return this.terms;
        }

    }
}
