using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Age { get => this.age; set => this.age = value; }


        public Person(int age)
        {
            Name = "No name";
            Age = age;
        }

        public Person()  
        {
            Name = "No name";
            Age = 1;
        }
    }
}
