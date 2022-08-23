using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo
{
    //struct Student //struct is a value type
    //{
    //    public int studentId;
    //    public string studentName;
    //}
    class Student
    {
        public int studentId;
        public string studentName;
    }
    class StructDemo
    {
        public void Main()
        {

            Student student1 = new Student();
            student1.studentId = 101;
            student1.studentName = "Nisha";
            Student student2 = student1;
            student2.studentName = "Niya";


            //ReadStudentData(student);

            DisplayStudentData(student1); //output 101 and Nisha
            DisplayStudentData(student2);//Output 101 and Niya
        }

        private void DisplayStudentData(Student student)
        {
            Console.WriteLine("Id\t Name");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"{student.studentId}\t{student.studentName}");
        }

        private void ReadStudentData(Student student)
        {
            Console.WriteLine("Enter Student Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student Name:");
            string name = Console.ReadLine();

            student.studentId = id;
            student.studentName = name;
        }
    }
}
