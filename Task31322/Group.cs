using System;
using System.Collections.Generic;
using System.Text;

namespace Task31322
{
    public class Group
    {

        public int No { get; }
        public static int no = 200;
        public Student[] Students;


        public Group(params Student[] students)
        {

            no++;
            No = no;
            Console.WriteLine($" Group created: BP{No}");

            Students = students;
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[^1] = student;


        }
        public void GetAllStudents()
        {
            foreach (var item in Students)
            {
                Console.WriteLine(item.Name);
            }
        }
        public void Sort()
        {
            Student temp;
            for (int i = 0; i < Students.Length-1; i++)
            {
                for (int j = 0; j < Students.Length-1; j++)
                {
                    if (Students[j].Point>Students[j+1].Point)
                    {
                         temp= Students[j];
                        Students[j] = Students[j + 1];
                        Students[j + 1] = temp;
                    }
                }
            }
            foreach (var item in Students)
            {
                Console.WriteLine($" Name: {item.Name} Point:{item.Point}");
            }

        }
    }
}
