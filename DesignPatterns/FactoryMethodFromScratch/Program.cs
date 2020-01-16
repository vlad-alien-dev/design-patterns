using System;

namespace FactoryMethodFromScratch
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new StudentCreator();
            var teacher = new TeacherCreator();
        }
    }
}
