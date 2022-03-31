using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task31322
{
    public class Student
    {
        private static int id;
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }
         public int ID { get; set; }
        public Student(string name,string surname,int age,int point)
        {
            Name = name;
            SurName = surname;
            Age = age;
            Point = point;
            ID = Interlocked.Increment(ref id);
        }
        public void ShowInfo()
        {
            Console.WriteLine($" Name: {Name} \n Surname: {SurName} \n Age: {Age} \n Point: {Point} \n ID:{ID} ") ;
        }
    }
}
