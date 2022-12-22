using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class Person
    {
        private int age;

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void Greet()
        {
            Console.WriteLine("Hello! I am a person and my age is " + age);
        }
    }
}