using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        private int age;
        public string Name { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }

        public string Introduction()
        {
            return $"Hi, I'm {Name} and I'm {age} years old.";
        }
    }
}

