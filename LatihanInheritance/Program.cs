using System;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas", 35, "190302", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Naima Zulfa", 18, "19.11.2735", "naima.zulfa@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
