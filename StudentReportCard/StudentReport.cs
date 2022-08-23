using System;
using System.Collections.Generic;
using System.Text;

namespace StudentReportCard
{
    public class StudentReport
    {
        private List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }
        public IEnumerable<Student> GetStudents()
        {
            return this.students;
        }
        public void Main()
        {

            StudentReport studentReport = new StudentReport();
            //1.create Subjects
            Subject subject1 = new Subject() { SubjectId = "S1001", SubjectName = "C#", ActualScore = 78, MinScore = 35 };
            Subject subject2 = new Subject() { SubjectId = "S1002", SubjectName = "DOTNET", ActualScore = 88, MinScore = 35 };
            Subject subject3 = new Subject() { SubjectId = "S1003", SubjectName = "OS", ActualScore = 58, MinScore = 35 };
            Subject subject4 = new Subject() { SubjectId = "S1004", SubjectName = "SE", ActualScore = 78, MinScore = 35 };
            Subject subject5 = new Subject() { SubjectId = "S1005", SubjectName = "Java", ActualScore = 75, MinScore = 35 };
            Subject subject6 = new Subject() { SubjectId = "S1006", SubjectName = "Linux", ActualScore = 79, MinScore = 35 };

            Subject subject7 = new Subject() { SubjectId = "S1001", SubjectName = "C#", ActualScore = 68, MinScore = 35 };
            Subject subject8 = new Subject() { SubjectId = "S1002", SubjectName = "DOTNET", ActualScore = 88, MinScore = 35 };
            Subject subject9 = new Subject() { SubjectId = "S1003", SubjectName = "OS", ActualScore = 28, MinScore = 35 };
            Subject subject10 = new Subject() { SubjectId = "S1004", SubjectName = "SE", ActualScore = 55, MinScore = 35 };
            Subject subject11 = new Subject() { SubjectId = "S1005", SubjectName = "Java", ActualScore = 60, MinScore = 35 };
            Subject subject12 = new Subject() { SubjectId = "S1006", SubjectName = "Linux", ActualScore = 61, MinScore = 35 };

            //2.Create Terms
            Term term1 = new Term() { TermId = "Term1" };
            Term term2 = new Term() { TermId = "Term2" };

            //3.Create Students
            Student student1 = new Student() { StudentId = 1001, StudentName = "Amala" };
            Student student2 = new Student() { StudentId = 1001, StudentName = "Remya" };
            studentReport.AddStudent(student1);
            studentReport.AddStudent(student2);


            //4.Add Subjects to Term
            term1.AddSubject(subject1);
            term1.AddSubject(subject2);
            term1.AddSubject(subject3);
            term1.AddSubject(subject4);
            term1.AddSubject(subject5);
            term1.AddSubject(subject6);

            term2.AddSubject(subject7);
            term2.AddSubject(subject8);
            term2.AddSubject(subject9);
            term2.AddSubject(subject10);
            term2.AddSubject(subject11);
            term2.AddSubject(subject12);

            //5.Add Term to Student
            student1.AddTerm(term1);
            student1.AddTerm(term2);

            student2.AddTerm(term1);
            student2.AddTerm(term2);

            //6.Display Student Report Card
            DisplayReportCard(studentReport);
        }



        private void DisplayReportCard(StudentReport studentReport)
        {
            Console.WriteLine("STUDENT REPORT");
            DrawLine(20, "-");
            foreach (var student in studentReport.GetStudents())
            {
                Console.WriteLine($"Student ID:{student.StudentId}\t\tStudent Name:{student.StudentName}");
                foreach (var term in student.GetTerms())
                {
                    Console.WriteLine($"Term ID:{term.TermId}");
                    DrawLine(20, "-");
                    Console.WriteLine("SubjectCode\tSubjectName\tMinimun Mark\tActual Mark\t\tResult");
                    DrawLine(80, "-");
                    foreach (var subject in term.GetSubjects())
                    {
                        Console.WriteLine($"{subject.SubjectId}\t\t{subject.SubjectName}\t\t\t{subject.MinScore}\t\t" +
                            $"{subject.ActualScore}\t\t{subject.GetSubjectResult()}");
                        Console.WriteLine();

                    }
                    DrawLine(80, "-");
                    Console.WriteLine($"Total Marks:\t\t\t\t\t\t{term.GetTermTotal()}");
                    DrawLine(80, "-");
                    Console.WriteLine($"Result\t\t\t\t\t\t{term.GetTermResult()}");
                    DrawLine(80, "*");
                }
                DrawLine(20, "-");
            }

        }

        private static void DrawLine(int noOfPrint, string pattern)
        {
            for (int i = 0; i < noOfPrint; i++)
            {
                Console.Write(pattern);
            }
            Console.WriteLine();
        }
    }

}

