using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class Student : Person
    {
        private int age;

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void Study()
        {
            Console.WriteLine("I'm studying.");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: " + age + " years old.");
        }
    }
}