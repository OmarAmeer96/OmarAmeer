// Tasks -- Omar Ameer Mohamed Ameen Mohamed -- Sec 6
using System;
namespace Tasks
{
    public abstract class Person
    {
        string Name;
        int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void Print();
    }
}