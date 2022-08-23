using System;

namespace TrainerTraineeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create Topic
            Topic topic1 = new Topic() { TopicName = "Simple if" };
            Topic topic2 = new Topic() { TopicName = "if else" };
            Topic topic3 = new Topic() { TopicName = "While" };
            Topic topic4 = new Topic() { TopicName = "For" };
            Topic topic5 = new Topic() { TopicName = "foreach" };
            Topic topic6 = new Topic() { TopicName = "Table tag" };
            Topic topic7 = new Topic() { TopicName = "Heading tags" };
            Topic topic8 = new Topic() { TopicName = "Text Formatting tags" };
            Topic topic9 = new Topic() { TopicName = "P tag" };

            //2.Create Unit
            
            Unit unit1 = new Unit() { UnitName = "Programming", UnitDuration = 40 };
            Unit unit2 = new Unit() { UnitName = "HTML basics", UnitDuration = 30 };
            Unit unit3 = new Unit() { UnitName = "JS Programming", UnitDuration = 20 };

            //3.Add Topic to Unit
            unit1.AddTopic(topic1);
            unit1.AddTopic(topic2);
            unit1.AddTopic(topic3);
            unit1.AddTopic(topic4);
            unit1.AddTopic(topic5);
            unit2.AddTopic(topic6);
            unit2.AddTopic(topic7);
            unit2.AddTopic(topic8);
            unit2.AddTopic(topic9);
            unit3.AddTopic(topic1);
            unit3.AddTopic(topic2);
            unit3.AddTopic(topic3);
            unit3.AddTopic(topic4);

            //4.Create Module
            Module module1 = new Module() { ModuleName = "C# Programming" };
            Module module2 = new Module() { ModuleName = "HTML Fundamentals" };
            Module module3 = new Module() { ModuleName = "JS Programming" };

            //5.Add Unit to Module
            module1.AddUnit(unit1);
            module2.AddUnit(unit2);
            module3.AddUnit(unit3);
            module1.AddUnit(unit3);

            //6.Create Course
            Course course = new Course() { CourseName = "C# Core" };

            //7.Add Module to Course
            course.AddModules(module1);
            course.AddModules(module2);
            course.AddModules(module3);

            //8.Create Technology
            Technology technology = new Technology() { TechnologyName = ".NET Core MVC" };

            //9.Add Technology to Course
            course.Technology = technology;

            //10.Add Course to Technology
            technology.Course = course;

            //11.Create Training
            Training training = new Training() { TrainingName = "B2B .NET Core Batch 17" };

            //12.Add Training to Course
            course.AddTrainings(training);

            //13.Add Course to Training
            training.Course = course;

            //14.Create Trainee
            Trainee trainee1 = new Trainee() { TraineeName = "Sam" };
            Trainee trainee2 = new Trainee() { TraineeName = "Ram" };
            Trainee trainee3 = new Trainee() { TraineeName = "Rahul" };
            Trainee trainee4 = new Trainee() { TraineeName = "Arun" };
            Trainee trainee5 = new Trainee() { TraineeName = "Vineeth" };

            //15.Add Trainee to Training
            training.AddTrainee(trainee1);
            training.AddTrainee(trainee2);
            training.AddTrainee(trainee3);
            training.AddTrainee(trainee4);
            training.AddTrainee(trainee5);

            //16.Add Training to Trainee
            trainee1.Training = training;
            trainee2.Training = training;
            trainee3.Training = training;
            trainee4.Training = training;
            trainee5.Training = training;

            //17.Create Trainer
            Trainer trainer = new Trainer() { TrainerName = "Vivek" };

            //18.Add Trainee to Trainer
            trainer.AddTrainees(trainee1);
            trainer.AddTrainees(trainee2);
            trainer.AddTrainees(trainee3);
            trainer.AddTrainees(trainee4);
            trainer.AddTrainees(trainee5);

            //19.Add Trainer to Trainee
            trainee1.Trainer = trainer;
            trainee2.Trainer = trainer;
            trainee3.Trainer = trainer;
            trainee4.Trainer = trainer;
            trainee5.Trainer = trainer;


            //20.Add Trainer to Training
            training.Trainer = trainer;

            //21.Add Training to Trainer
            trainer.Training = training;
            //22.DisplayTrainingInfo
            DisplayTrainingInfo(training);
        }

        private static void DisplayTrainingInfo(Training training)
        {
            
            Console.WriteLine("Training Information");
            DrawLine(20, "-");
            Console.WriteLine($"Training Name: {training.TrainingName}\t Training Duration:{training.GetTotalTrainingDuration()}");
            Console.WriteLine($"Trainer Name :{training.Trainer.TrainerName}");
            DrawLine(20, "-");
            Console.WriteLine($"Trainees Info");
            DrawLine(20, "-");
            foreach (var trainee in training.GetTrainees())
            {
                Console.WriteLine(trainee.TraineeName);
            }
            DrawLine(20, "_");
            Console.WriteLine($"Technology:{training.Course.Technology.TechnologyName}");
            Console.WriteLine($"Course Name:{training.Course.CourseName}\t Course Duration:{training.Course.GetCourseDuration()}");
            foreach (var module in training.Course.GetModules())
            {
                Console.WriteLine($"\tModule Name:{module.ModuleName} \t Module Duration:{module.GetModuleDuration()}");
                foreach (var unit in module.GetUnits())
                {
                    Console.WriteLine($"\t\tUnits :{unit.UnitName}\t Duration:{unit.UnitDuration}");
                    foreach (var topics in unit.GetTopics())
                    {
                        Console.WriteLine($"\t\tTopic Name:{topics.TopicName}");
                        
                    }
                }
                
            }


        }

        private static void DrawLine(int noOfPrint, string pattern)
        {
            for(int i=0;i<noOfPrint;i++)
            {
                Console.Write(pattern);
            }
            Console.WriteLine();
        }
    }
}
