using System;
using System.Collections.Generic;
using System.Text;

namespace StudentReportCard
{
    public class Subject
    {
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int ActualScore { get; set; }
        public int MinScore { get; set; }

        public string GetSubjectResult()
        {
            string result = "Fail";
            if(ActualScore>=MinScore)
            {
                result = "Pass";
            }
            return result;
        }
    }
}
