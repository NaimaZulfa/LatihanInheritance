using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritance
{
    class Teacher : Person
    {
        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public Teacher(string name = "no name", int age = 0, string teacherId = "no id", string subject = "no subject")
        {
            Name = name;
            Age = age;
            TeacherId = teacherId;
            Subject = subject;
        }
    }
}
