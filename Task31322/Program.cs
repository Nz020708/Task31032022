using System;

namespace Task31322
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Anna", "James", 22, 70);
            Student student2 = new Student("Mark", "gvhjmgbjm", 12, 100);
            Student student3 = new Student("Jane", "jhgj", 32, 90);
            Student student4 = new Student("Tom", "hjvhj", 72, 0);
            student1.ShowInfo();
            student2.ShowInfo();
            student3.ShowInfo();
            Group group = new Group(student1, student2, student3);
            group.AddStudent(student4);
            group.GetAllStudents();
            group.Sort();



        }

    }
}
