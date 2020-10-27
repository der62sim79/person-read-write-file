using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCSharpApp
{
    class Person
    {
        public string name;
        public int age;
        public string city;
        public string job;
        public string toString()
        {
            return "Name: " + name + " - Alter: " + age + " - Stadt: " + city + " - Beruf: " + job;
        }
    }
}
