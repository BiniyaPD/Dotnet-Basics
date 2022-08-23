using System;

namespace AssessmentQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //IA a = new IAImpl();
            //a.Show();

            //MyRepo myRepo = new MyRepo();
            //myRepo.Show();

            //MyClass myClass = new MyClass();
            //myClass.Show(10);

            //MyClass1Impl myClassImpl = new MyClass1Impl();
            //myClassImpl.Show();

            DerivedClass d = new DerivedClass(10);

            MyClass2Impl myClassImpl = new MyClass2Impl();
            myClassImpl.Show();
        }
    }
}
