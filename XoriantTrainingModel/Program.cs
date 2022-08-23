using System;
using System.Linq;

namespace XoriantTrainingModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.create questions
            Question question1 = new McqQuestion("Question1", "A","B", "C",  "D", "C", 2);
            Question question2 = new McqQuestion("Question2", "A", "B", "C", "D", "A", 2);
            Question question3 = new McqQuestion("Question3", "A", "B", "C", "D", "B", 2);
            Question question4 = new McqQuestion("Question4", "A", "B", "C", "D", "B", 2);
            Question question5 = new McqQuestion("Question5", "A", "B", "C", "D", "C", 2);
            Question question6 = new McqQuestion("Question6", "True", "False", "True", 2);
            Question question7 = new McqQuestion("Question7", "True", "False", "False", 2);
            Question question8 = new McqQuestion("Question8", "True", "False", "True", 2);
            Question question9 = new HandsOnQuestion("Case Study1","doc1",50);
            Question question10 = new HandsOnQuestion("Case Study2", "doc2", 50);
            Question question11 = new HandsOnQuestion("POC", "doc3", 100);


            //2.Create Assessment
            Assessment assessment1 = new Assessment() { AssessmentId = 1, DateAssessment = DateTime.UtcNow, Desc = "Language Basics" };
            Assessment assessment2 = new Assessment() { AssessmentId = 2, DateAssessment = DateTime.UtcNow, Desc = "OOPS Concept" };
            Assessment assessment3 = new Assessment() { AssessmentId = 3, DateAssessment = DateTime.UtcNow, Desc = "Collections" };
            Assessment assessment4 = new Assessment() { AssessmentId = 4, DateAssessment = DateTime.UtcNow, Desc = "Case study1" };
            Assessment assessment5 = new Assessment() { AssessmentId = 4, DateAssessment = DateTime.UtcNow, Desc = "Pre Assessment" };

            //3.Add Questions to Assessment
            assessment1.AddQuestion(question1);
            assessment1.AddQuestion(question2);
            assessment1.AddQuestion(question3);
            assessment2.AddQuestion(question4);
            assessment2.AddQuestion(question5);
            assessment2.AddQuestion(question6);
            assessment3.AddQuestion(question7);
            assessment3.AddQuestion(question8);
            assessment3.AddQuestion(question9);
            assessment4.AddQuestion(question10);
            assessment4.AddQuestion(question11);
            assessment5.AddQuestion(question1);
            assessment5.AddQuestion(question2);
           

            //4.Create Course
            Course course1 = new Course( 10, "C# Programmming",assessment1 );
            Course course2 = new Course(11,".NET Core",assessment4);
            Course course3 = new Course(12, "JavaScript", assessment2);

            //5.Adding Assessments to Course
            //course1.AddAssessment(assessment1);
            course1.AddAssessment(assessment2);
            course1.AddAssessment(assessment3);
            //course2.AddAssessment(assessment4);
            course2.AddAssessment(assessment1);
            //course3.AddAssessment(assessment2);
            course3.AddAssessment(assessment3);

            //6.Create Iteration
            Iteration iteration1 = new Iteration() { IterationNo = 1, Goal = "Basic understanding of C#",Course=course1 };
            Iteration iteration2 = new Iteration() { IterationNo = 2, Goal = "Basic understanding of .NET", Course = course2 };
            Iteration iteration3 = new Iteration() { IterationNo = 3, Goal = "Basic understanding of JavaScript", Course = course3 };

            //7.Adding Assessments to Iteration
            iteration1.AddAssessment(assessment5);
            iteration2.AddAssessment(assessment5);

            //8.Create Training Model
            TrainingModel trainingModel = new TrainingModel("Xoriant",iteration1,iteration2,iteration3);

            //10.Display Training Model
            DisplayTrainingModel(trainingModel);


        }

        private static void DisplayTrainingModel(TrainingModel trainingModel)
        {
            Console.WriteLine("Xoriant Training Framework");
            DrawLine(60, "*");
            Console.WriteLine($"Client Name:\t{trainingModel.ClientName}");
            Console.WriteLine($"Total Number Of Assessment:{trainingModel.GetTotalAssessmentsInTheTraining()}");
            Console.WriteLine($"Total Score of all the Assignments:{trainingModel.GetTotalScoreOfAllAssignment()}");
            foreach (var iteration in trainingModel.GetIterations())
            {
                Console.WriteLine($"Iteration No.:\t{iteration.IterationNo}\tIteration Goal:{iteration.Goal}");
                DrawLine(80, "-");
                Console.WriteLine($"Course Id:{iteration.Course.CourseId}\tCourse Name:{iteration.Course.courseName}");
                Console.WriteLine($"Number of Course Based Assessment:{iteration.Course.GetAssessments().Count()}");
                Console.WriteLine();
                Console.WriteLine($"Ass Id\tDesc\t\tNoOfQuestion\t\tDate\t\tTotal Mark");
                foreach (var assessment in iteration.Course.GetAssessments())
                {
                    Console.WriteLine($"{assessment.AssessmentId}\t{assessment.Desc}\t{assessment.NoQoestions}\t\t{assessment.DateAssessment}\t\t{assessment.GetTotalMarks()}");
                    Console.WriteLine();
                   
                    Console.WriteLine($"Total Number of MCQ question:{assessment.GetNumberMcq()}");
                    Console.WriteLine($"Total Number of HandsOn question:{assessment.GetNumberHandson()}");
                    DrawLine(80, "-");

                }
                DrawLine(80, "*");
                Console.WriteLine($"Number of Non Course Based Assessment:{iteration.GetAssessments().Count()}");
                foreach (var additionalAssessment in iteration.GetAssessments())
                {
                    Console.WriteLine($"{additionalAssessment.AssessmentId}\t\t{additionalAssessment.Desc}\t{additionalAssessment.NoQoestions}\t{additionalAssessment.DateAssessment}\t\t{additionalAssessment.GetTotalMarks()}");
                    Console.WriteLine();
                   
                    Console.WriteLine($"Total Number of MCQ question:{additionalAssessment.GetNumberMcq()}");
                    Console.WriteLine($"Total Number of HandsOn question:{additionalAssessment.GetNumberHandson()}");
                    DrawLine(80, "-");
                }
                DrawLine(80, "*");

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
