using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class StudentProfessorTest
    {
        public static void Main(string[] args)
        {
            // Create a new Person and say hello
            Person person = new Person();
            person.SetAge(25);
            person.Greet();

            // Create a new Student, set an age, say hello, and display age on the screen
            Student student = new Student();
            student.SetAge(20);
            student.Study();
            student.ShowAge();

            // Create a new Teacher, set an age, say hello and start the explanation
            Teacher teacher = new Teacher();
            teacher.SetAge(50);
            teacher.Greet();
            teacher.Explain();
        }
    }
}
